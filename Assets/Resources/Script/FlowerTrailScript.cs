using UnityEngine;
using System.Collections;

public class FlowerTrailScript : MonoBehaviour {
	
	public float timerStay;
	float timer;
	ParticleSystem partSyst;

	// Use this for initialization
	void Start () {
		timer = 0;
		partSyst = this.gameObject.GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0)
		{
			partSyst.Stop();
		}
	}

	public void startTrail () {
		timer = timerStay;
		partSyst.Play ();
	}
}
