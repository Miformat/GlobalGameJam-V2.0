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

	public AudioClip[] empreinte;
	[HideInInspector]public bool isTrail;
	public AudioClip[] color;
	[HideInInspector]public bool isColor;

	public AudioClip[] credit;
	public AudioClip[] aurore;

	public AudioClip[] jour;
    [HideInInspector]public bool isDay = true;
	public AudioClip[] nuit;

	public AudioClip[] meteo4;
    public AudioClip[] meteoClair;
    public AudioClip[] meteoNeige;
    public AudioClip[] meteoPluie;

    [HideInInspector]
    public MeteoManager.Weather meteo = MeteoManager.Weather.CLEAR;

    public AudioClip[] vol;
    [HideInInspector]
    public bool isFlying;

	Collider[] hitColliders;

    public float trackDuration = 4.5f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > trackDuration) 
		{
			timer = timer % trackDuration;
			hitColliders = Physics.OverlapSphere(this.gameObject.transform.position, radius);
			checkCol ();
			playTrack();
		}
	}

	void checkCol () {
		foundTree = foundBush = foundRock = foundBird = foundButterfly = foundDragonfly = foundPlant1 = foundPlant2 = false;
		foreach(Collider col in hitColliders)
		{
            //Debug.Log(col.tag + " " + col.name);

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
		if (foundTree){ PlaySoundOnPlayer(arbre[rnd]);}
		if (foundBush) { PlaySoundOnPlayer(buisson[rnd]);}
		if (foundRock) { PlaySoundOnPlayer(caillou[rnd]);}
		if (foundBird){ PlaySoundOnPlayer(oiseau[rnd]);}
		if (foundButterfly){ PlaySoundOnPlayer(papillon[rnd]);}
		if (foundDragonfly){ PlaySoundOnPlayer(luciole[rnd]);}
		if (foundPlant1){ PlaySoundOnPlayer(plant1[rnd]);}
		if (foundPlant2){ PlaySoundOnPlayer(plant2[rnd]);}
        if (isFlying) { PlaySoundOnPlayer(vol[rnd]); }

		if (isTrail) { PlaySoundOnPlayer(empreinte[rnd]); }
		if (isColor) { PlaySoundOnPlayer(color[rnd]); }
		isColor = false;

        if (isDay) {
            PlaySoundOnPlayer(jour[rnd]);
        }
        else
        {
            PlaySoundOnPlayer(nuit[rnd]);
        }

        switch (meteo)
        {
            case MeteoManager.Weather.CLEAR:
                PlaySoundOnPlayer(meteoClair[rnd]);
                break;
            case MeteoManager.Weather.RAIN:
                PlaySoundOnPlayer(meteoPluie[rnd]);
                break;
            case MeteoManager.Weather.SNOW:
                PlaySoundOnPlayer(meteoNeige[rnd]);
                break;
            case MeteoManager.Weather.OTHER:
                PlaySoundOnPlayer(meteo4[rnd]);
                break;
        }
    }

    public void PlaySoundOnPlayer(AudioClip aC)
    {
        GameObject go = new GameObject("TempAudio");

        go.transform.parent = transform.parent;
        go.transform.position = Vector3.zero;

        AudioSource aSource = go.AddComponent<AudioSource>();
        aSource.clip = aC; 

        aSource.Play();
        Destroy(go, aC.length);
    }
}
