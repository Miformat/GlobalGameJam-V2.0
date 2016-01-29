using UnityEngine;
using System.Collections;

public class curveScript : MonoBehaviour {


	public AnimationCurve sizecurve ;
	float Timer;


	// Use this for initialization
	void Start () {
		Timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;
		transform.localScale = Vector3.one * sizecurve.Evaluate(Timer);
		//if (Timer > 1.0f){Timer = 0;;}
	}
}
