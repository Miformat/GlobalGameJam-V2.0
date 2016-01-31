using UnityEngine;
using System.Collections;

public class FlowerTrailScript : MonoBehaviour {
	
	public float timerStay;
	float timer;
	ParticleSystem partSyst;
	TrackManager TM;

	// Use this for initialization
	void Start () {
		timer = 0;
		partSyst = this.gameObject.GetComponent<ParticleSystem> ();
		TM = FindObjectOfType<TrackManager>();
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0)
		{
			TM.isTrail = false;
			partSyst.Stop();
		}
	}

	public void startTrail () {
		timer = timerStay;
		TM.isTrail = true;
		partSyst.Play ();
	}
}
