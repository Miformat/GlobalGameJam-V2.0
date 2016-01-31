using UnityEngine;
using System.Collections;

public class notePopScript : MonoBehaviour {

	Vector3 Pos;
	Camera cam;
	public bool sizeDown;

	// Use this for initialization
	void Start () {
		sizeDown = false;
		cam = Camera.main;
		Pos = this.gameObject.transform.position;
		Pos.y += 4f;
		this.gameObject.transform.position = Pos;
		Pos = cam.transform.position;
		Pos = cam.ViewportToWorldPoint (new Vector3 (0, 1, 0));
		Pos.x += 20;
		Pos.y += 40;
		//Pos.z += 0;
		//Debug.Log (Pos);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, Pos, 0.05f);
		transform.LookAt (cam.transform);
		if (sizeDown){transform.localScale -= new Vector3 (0.01f,0.01f,0.01f);}
		if (transform.localScale.x < 0.05){Destroy(this.gameObject);}
	}
}
