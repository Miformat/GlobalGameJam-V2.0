using UnityEngine;
using System.Collections;

public class noteParticleScript : MonoBehaviour {

	GameObject partNoteZ;
	GameObject partNoteQ;
	GameObject partNoteS;
	GameObject partNoteD;
	float timer;

	// Use this for initialization
	void Start () {
		partNoteZ = GameObject.Find ("PartNoteZ");
		partNoteQ = GameObject.Find ("PartNoteQ");
		partNoteS = GameObject.Find ("PartNoteS");
		partNoteD = GameObject.Find ("PartNoteD");
		partNoteZ.SetActive (false);
		partNoteQ.SetActive (false);
		partNoteS.SetActive (false);
		partNoteD.SetActive (false);
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0) 
		{
			partNoteZ.SetActive (false);
			partNoteQ.SetActive (false);
			partNoteS.SetActive (false);
			partNoteD.SetActive (false);
		}
	}

	public void playParticle(string ID)
	{
		switch(ID)
		{
			case "z":
				partNoteZ.SetActive (true);
				break;
			case "q":
				partNoteQ.SetActive (true);
				break;
			case "s":
				partNoteS.SetActive (true);
				break;
			case "d":
				partNoteD.SetActive (true);
				break;
			default:
				break;
		}
		timer = 1.5f;
	}
}
