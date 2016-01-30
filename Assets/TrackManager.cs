using UnityEngine;
using System.Collections;

public class TrackManager : MonoBehaviour {

	public float timer;
	public float radius;

	public AudioClip[] arbre;
	bool foundTree;
	public AudioClip[] buisson;
	bool foundBush;
	public AudioClip[] caillou;
	bool foundRock;
	public AudioClip[] oiseau;
	bool foundBird;
	public AudioClip[] papillon;
	bool foundButterfly;
	public AudioClip[] luciole;
	bool foundDragonfly;
	public AudioClip[] plant1;
	bool foundPlant1;
	public AudioClip[] plant2;
	bool foundPlant2;
	//public AudioClip[] plant3;
	//bool foundPlant3;

	public AudioClip[] empreinte;//play when active
	public AudioClip[] credit;

	public AudioClip[] color;
	public AudioClip[] aurore;

	public AudioClip[] jour;
	public AudioClip[] nuit;

	public AudioClip[] meteo4;
	public AudioClip[] meteoClair;
	public AudioClip[] meteoNeige;
	public AudioClip[] meteoPluie;

	public AudioClip[] vol;

	Collider[] hitColliders;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 5) 
		{
			timer = timer % 5;
			hitColliders = Physics.OverlapSphere(this.gameObject.transform.position, radius);
			checkCol ();
			playTrack();
		}
	}

	void checkCol () {
		foundTree = foundBush = foundRock = foundBird = foundButterfly = foundDragonfly = foundPlant1 = foundPlant2 = false;
		foreach(Collider col in hitColliders)
		{
			switch(col.tag)
			{
				case "Tree":
				foundTree = true;
					break;
				case "Rock":
				foundRock = true;
					break;
				case "Buisson":
				foundBush = true;
					break;
				case "Bird":
				foundBird = true;
					break;
				case "Butterfly":
				foundButterfly = true;
					break;
				case "Dragonfly":
				foundDragonfly = true;
					break;
				case "Plante":
				foundPlant1 = true;
					break;
				case "Plante2":
				foundPlant2 = true;
					break;
			}
		}
	}

	public void playTrack () 
	{
		int rnd = Random.Range (0,3);
		if (foundTree){AudioSource.PlayClipAtPoint(arbre[rnd], this.gameObject.transform.position);}
		if (foundRock){AudioSource.PlayClipAtPoint(buisson[rnd], this.gameObject.transform.position);}
		if (foundBush){AudioSource.PlayClipAtPoint(caillou[rnd], this.gameObject.transform.position);}
		if (foundBird){AudioSource.PlayClipAtPoint(oiseau[rnd], this.gameObject.transform.position);}
		if (foundButterfly){AudioSource.PlayClipAtPoint(papillon[rnd], this.gameObject.transform.position);}
		if (foundDragonfly){AudioSource.PlayClipAtPoint(luciole[rnd], this.gameObject.transform.position);}
		if (foundPlant1){AudioSource.PlayClipAtPoint(plant1[rnd], this.gameObject.transform.position);}
		if (foundPlant2){AudioSource.PlayClipAtPoint(plant2[rnd], this.gameObject.transform.position);}
	}
}
