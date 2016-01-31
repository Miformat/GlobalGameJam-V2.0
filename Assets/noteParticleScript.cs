using UnityEngine;
using System.Collections;

public class noteParticleScript : MonoBehaviour {

	public GameObject partNoteZ;
	public GameObject partNoteQ;
	public GameObject partNoteS;
	public GameObject partNoteD;
	GameObject go;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void playParticle(string ID)
	{
		switch(ID)
		{
			case "z":
				go = Instantiate(partNoteZ);
				go.transform.parent = this.gameObject.transform;
				break;
			case "q":
				go = Instantiate(partNoteQ);
				go.transform.parent = this.gameObject.transform;
				break;
			case "s":
				go = Instantiate(partNoteS);
				go.transform.parent = this.gameObject.transform;
				break;
			case "d":
				go = Instantiate(partNoteD);
				go.transform.parent = this.gameObject.transform;
				break;
			default:
				break;
		}
	}
}
