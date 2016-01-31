using UnityEngine;
using System.Collections;

public class BugsIA : MonoBehaviour {
	
	public float speed;
	Vector3 target;
	float timer;
	int sec;

	void Start () {
		target = ResetTarget();
		sec = ResetSec();
	}
	
	void Update () {
		timer += Time.deltaTime;
		if(timer > sec || transform.position.y < 0.5f)
		{
			target = ResetTarget();
			sec = ResetSec();
		}
		transform.Translate(target * speed * Time.deltaTime);
	}

	Vector3 ResetTarget()
	{
		float xGo = Random.Range (-2, 2);
		float yGo = Random.Range (-2, 2);
		float zGo = Random.Range (-2, 2);
		if (transform.position.y < 0.5f && yGo < 0){yGo *= -1;}
		Vector3 toReturn = new Vector3(xGo, yGo, zGo);
		return toReturn;
	}
	int ResetSec()
	{
		timer = 0;
		return Random.Range(1,3);
	}
}
