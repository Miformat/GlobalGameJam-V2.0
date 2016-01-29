using UnityEngine;
using System.Collections;

public class curveScript : MonoBehaviour {


	AnimationCurve popCurve ;
	AnimationCurve depopCurve ;
	float Timer;
	Vector3 scaleVect;
	bool depop;

	// Use this for initialization
	void Start () {
		depop = false;
		popCurve = GameObject.FindGameObjectWithTag ("Spell").GetComponent<SpellManager>().popCurve;
		depopCurve = GameObject.FindGameObjectWithTag ("Spell").GetComponent<SpellManager>().depopCurve;
		Timer = 0;
		scaleVect = Vector3.one;
	}
	
	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;
		if (depop == false) 
		{
			scaleVect.x = 0f + popCurve.Evaluate (Timer);
			scaleVect.y = 2f - popCurve.Evaluate(Timer);
			scaleVect.z = 0f + popCurve.Evaluate(Timer);
			transform.localScale = scaleVect;
			//if (Timer > 1.0f){Timer = 0;}
		}
		else
		{
			scaleVect.x = 0f + depopCurve.Evaluate (Timer);
			scaleVect.y = 0f - depopCurve.Evaluate(Timer);
			scaleVect.z = 0f + depopCurve.Evaluate(Timer);
			transform.localScale = scaleVect;
			if (Timer > 1){Destroy(this.gameObject);}
		}
	}

	public void goDepop()
	{
		if (depop == false) 
		{
			depop = true;
			Timer = 0;
		}
	}
}
