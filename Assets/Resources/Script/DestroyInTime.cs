﻿using UnityEngine;
using System.Collections;

public class DestroyInTime : MonoBehaviour {

	public float timer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0){Destroy(this.gameObject);}
	}
}
