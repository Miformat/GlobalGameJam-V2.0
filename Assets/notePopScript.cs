using UnityEngine;
using System.Collections;

public class notePopScript : MonoBehaviour {

	Vector3 startPos;
	Vector3 endPos;

	// Use this for initialization
	void Start () {
		startPos = this.gameObject.transform.position;
		startPos.y += 4f;
		this.gameObject.transform.position = startPos;
		endPos = this.gameObject.transform.position;
		endPos.x += 30;
		endPos.y += 30;
		endPos.z += 30;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, endPos, 0.05f);
	}
}
