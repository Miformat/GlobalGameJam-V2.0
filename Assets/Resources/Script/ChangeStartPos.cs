using UnityEngine;
using System.Collections;

public class ChangeStartPos : MonoBehaviour {
	
	public Vector3 pos;
	public Vector3 rot;
	// Use this for initialization
	void Start () {
		this.gameObject.transform.position += pos;
		this.gameObject.transform.Rotate(rot);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
