using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class PartitionManager : MonoBehaviour {

    static PartitionManager instance;

	GameObject[] constel;
	Transform[] stars;

    public static PartitionManager Instance
    {
        get
        {
            return instance;
        }
    }
    
    public enum constellationType
    {
        PONCTUELS,
        EFFETS,
        INTERACTIONS,
        AMBIANCE,
        GAMEPLAY
    }

    public Dictionary<string, bool> discoveredSongs;

    public Dictionary<constellationType, List<string>> constellations;

    void Awake()
    {
        instance = this;
        discoveredSongs = new Dictionary<string, bool>();
        constellations = new Dictionary<constellationType, List<string>>();
        
        InitConstellations();
		constel = GameObject.FindGameObjectsWithTag("Const");
    }
    
    void InitConstellations()
    {
        constellations[constellationType.PONCTUELS] = new List<string>();
        constellations[constellationType.PONCTUELS].Add("element");
        constellations[constellationType.PONCTUELS].Add("plante");
        constellations[constellationType.PONCTUELS].Add("plante2");
        constellations[constellationType.PONCTUELS].Add("petitRocher");
        constellations[constellationType.PONCTUELS].Add("papillon");
        constellations[constellationType.PONCTUELS].Add("arbres");
        constellations[constellationType.PONCTUELS].Add("buissons");
        constellations[constellationType.PONCTUELS].Add("oiseaux");

        constellations[constellationType.EFFETS] = new List<string>();
        constellations[constellationType.EFFETS].Add("empreintesPlantes");
        constellations[constellationType.EFFETS].Add("feuArtifice");
        constellations[constellationType.EFFETS].Add("couleur");
        constellations[constellationType.EFFETS].Add("feuillir");
        constellations[constellationType.EFFETS].Add("fleurir");
        constellations[constellationType.EFFETS].Add("effacer");

        constellations[constellationType.INTERACTIONS] = new List<string>();
        constellations[constellationType.INTERACTIONS].Add("ouvrir");
        constellations[constellationType.INTERACTIONS].Add("fermer");
        constellations[constellationType.INTERACTIONS].Add("eteindre");
        constellations[constellationType.INTERACTIONS].Add("allumer");
        constellations[constellationType.INTERACTIONS].Add("remplirEau");
        constellations[constellationType.INTERACTIONS].Add("assecher");

        constellations[constellationType.AMBIANCE] = new List<string>();
        constellations[constellationType.AMBIANCE].Add("meteo4");
        constellations[constellationType.AMBIANCE].Add("pluie");
        constellations[constellationType.AMBIANCE].Add("neige");
        constellations[constellationType.AMBIANCE].Add("auroreBoreale");
        constellations[constellationType.AMBIANCE].Add("meteoClaire");
        constellations[constellationType.AMBIANCE].Add("jour");
        constellations[constellationType.AMBIANCE].Add("nuit");

        constellations[constellationType.GAMEPLAY] = new List<string>();
        constellations[constellationType.GAMEPLAY].Add("constellations");
        constellations[constellationType.GAMEPLAY].Add("boussole");
        constellations[constellationType.GAMEPLAY].Add("voler");
        constellations[constellationType.GAMEPLAY].Add("credit");
    }

	public void doAction(string song)
	{
		int IDCONST = 0;
		int IDSTAR = 0;
		switch (song) 
		{
		case "element":
				IDCONST = 1;
				IDSTAR = 1;
                Element();
			break;
		case "plante":
				IDCONST = 1;
				IDSTAR = 2;
                Plante();
			break;
		case "destroyplante":
                DestroyPlante();
			break;
		case "plante2":
				IDCONST = 1;
				IDSTAR = 3;
                PlanteDeux();
			break;
		case "destroyplante2":
                DestroyPlanteDeux();
			break;
		case "empreintesPlantes":
				IDCONST = 2;
				IDSTAR = 1;
                EmpreintesPlantes();
			break;
		case "petitRocher":
				IDCONST = 1;
				IDSTAR = 4;
                PetitRocher();
			break;
		case "destroypetitRocher":
                DestroyPetitRocher();
			break;
		case "papillon":
				IDCONST = 1;
				IDSTAR = 5;
                Papillon();
			break;
		case "luciole":
				IDCONST = 1;
				IDSTAR = 6;
				Luciole();
			break;
		case "ouvrir":
				IDCONST = 3;
				IDSTAR = 1;
                Ouvrir();
			break;
		case "fermer":
				IDCONST = 3;
				IDSTAR = 2;
                Fermer();
			break;
		case "arbres":
				IDCONST = 1;
				IDSTAR = 7;
                Arbres();
			break;
		case "destroyArbres":
                DestroyArbres();
			break;
		case "buissons":
				IDCONST = 1;
				IDSTAR = 8;
                Buissons();
			break;
		case "destroybuissons":
                DestroyBuissons();
			break;
		case "constellations":
				IDCONST = 5;
				IDSTAR = 1;
                Constellations();
			break;
		case "feuArtifice":
				IDCONST = 2;
				IDSTAR = 2;
                FeuArtifice();
			break;
		case "meteo4":
				IDCONST = 4;
				IDSTAR = 1;
                MeteoQuatre();
			break;
		case "couleur":
				IDCONST = 2;
				IDSTAR = 3;
                Couleur();
			Debug.Log("couleur");
			break;
		case "pluie":
				IDCONST = 4;
				IDSTAR = 2;
                Pluie();
			break;
		case "neige":
				IDCONST = 4;
				IDSTAR = 3;
                Neige();
			break;
		case "boussole":
				IDCONST = 5;
				IDSTAR = 2;
                Boussole();
			Debug.Log("boussole");
			break;
		case "meteoClaire":
				IDCONST = 4;
				IDSTAR = 4;
                MeteoClaire();
			break;
		case "voler":
				IDCONST = 5;
				IDSTAR = 3;
                Voler();
			break;
		case "fleurir":
				IDCONST = 2;
				IDSTAR = 4;
                Fleurir();
			Debug.Log("fleurir");
			break;
		case "feuillir":
				IDCONST = 2;
				IDSTAR = 5;
                Feuillir();
			Debug.Log("feuillir");
			break;
		case "eteindre":
				IDCONST = 3;
				IDSTAR = 3;
                Eteindre();
			break;
		case "oiseaux":
				IDCONST = 1;
				IDSTAR = 9;
                Oiseaux();
			break;
		case "allumer":
				IDCONST = 3;
				IDSTAR = 4;
                Allumer();
			break;
		case "auroreBoreale":
				IDCONST = 4;
				IDSTAR = 5;
                AuroreBoreale();
			Debug.Log("auroreBoreale");
			break;
		case "assecher":
				IDCONST = 3;
				IDSTAR = 5;
                Assecher();
			break;
		case "jour":
				IDCONST = 4;
				IDSTAR = 6;
                Jour();
			break;
		case "credit":
				IDCONST = 5;
				IDSTAR = 4;
                Credit();
			Debug.Log("credit");
			break;
		case "effacer":
				IDCONST = 2;
				IDSTAR = 6;
                Effacer();
			break;
		case "remplirEau":
				IDCONST = 3;
				IDSTAR = 6;
                RemplirEau();
			break;
		case "nuit":
				IDCONST = 4;
				IDSTAR = 7;
                Nuit();
			break;
		}

        UnlockSong(song, IDCONST, IDSTAR);

	}

    private void Nuit()
    {
        MeteoManager.Instance.SetDay(false);
    }

    private void RemplirEau()
    {
		FindObjectOfType<Interaction>().Interact(Interaction.interactionType.WATER, true);
    }

    private void Credit()
    {
        throw new NotImplementedException();
    }

    private void Jour()
    {
        MeteoManager.Instance.SetDay(true);
    }

    private void Assecher()
    {
		FindObjectOfType<Interaction>().Interact(Interaction.interactionType.WATER, false);
    }

    private void AuroreBoreale()
    {
        throw new NotImplementedException();
    }

    private void Allumer()
    {
		FindObjectOfType<Interaction>().Interact(Interaction.interactionType.LIGHT, true);
    }

    private void Oiseaux()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.OISEAUX);
    }

    private void Eteindre()
    {
		FindObjectOfType<Interaction>().Interact(Interaction.interactionType.LIGHT, false);
    }

    private void Feuillir()
    {
        FindObjectOfType<Interaction>().Interact(Interaction.interactionType.LEAVES, true);
    }

    private void Fleurir()
    {
        throw new NotImplementedException();
    }

    private void Voler()
    {
        FindObjectOfType<PlayerController>().Fly();
    }

    private void MeteoClaire()
    {
        MeteoManager.Instance.SwitchWeather(MeteoManager.Weather.CLEAR);
    }

    private void Boussole()
    {
        throw new NotImplementedException();
    }

    private void Neige()
    {
        MeteoManager.Instance.SwitchWeather(MeteoManager.Weather.SNOW);
    }

    private void Pluie()
    {
        MeteoManager.Instance.SwitchWeather(MeteoManager.Weather.RAIN);
    }

    private void Couleur()
    {
        throw new NotImplementedException();
    }

    private void MeteoQuatre()
    {
        MeteoManager.Instance.SwitchWeather(MeteoManager.Weather.OTHER);
    }

    private void FeuArtifice()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.ARTIFICE);
    }

    private void Constellations()
    {
		GameObject[] constel = GameObject.FindGameObjectsWithTag("Const");
		foreach(GameObject go in constel)
		{
			go.GetComponent<ConstScript>().showLink();
		}
    }

    private void DestroyBuissons()
    {
		FindObjectOfType<Invocation>().Uninvoc(SpellManager.spellType.BUISSON);
    }

    private void Buissons()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.BUISSON);
    }

    private void DestroyArbres()
    {
        FindObjectOfType<Invocation>().Uninvoc(SpellManager.spellType.TREE);
    }

    private void Fermer()
    {
		FindObjectOfType<Interaction>().Interact(Interaction.interactionType.OPEN, false);
    }

    private void Ouvrir()
    {
		FindObjectOfType<Interaction>().Interact(Interaction.interactionType.OPEN, true);
    }

    private void Papillon()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.PAPILLON);
    }

	private void Luciole()
	{
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.LUCIOLE);
	}

    private void DestroyPetitRocher()
    {
        FindObjectOfType<Invocation>().Uninvoc(SpellManager.spellType.ROCK);
    }

    private void EmpreintesPlantes()
    {
		GameObject.FindGameObjectWithTag ("FlowerTrail").GetComponent<FlowerTrailScript> ().startTrail ();
    }

    private void DestroyPlanteDeux()
    {
		FindObjectOfType<Invocation>().Uninvoc(SpellManager.spellType.PLANTE2);
    }

    private void PlanteDeux()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.PLANTE2);
    }

    private void DestroyPlante()
    {
		FindObjectOfType<Invocation>().Uninvoc(SpellManager.spellType.PLANTE);
    }

    private void Plante()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.PLANTE);
    }

    private void Element()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.ELEMENT);
    }

    void Effacer()
    {
        FindObjectOfType<Invocation>().Uninvoc(SpellManager.spellType.ALL);
    }

    void Arbres()
    {
        FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.TREE);
    }

    void PetitRocher()
    {
        FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.ROCK);
    }

    void UnlockSong(string song, int idConst, int idStar)
    {
		if (idConst > 0 && idStar > 0)
		{
			if (!discoveredSongs.ContainsKey(song))
			{
				discoveredSongs[song] = true;
				activeConstellations(idConst, idStar);
			}
		}
    }

    void activeConstellations(int ConstID, int StarID)
    {
		foreach(GameObject co in constel)
		{
			if (co.GetComponent<ConstScript>().ID == ConstID)
			{
				stars = co.GetComponentsInChildren<Transform>();
				foreach(Transform st in stars)
				{
					if (st.tag == "Star" && st.GetComponent<StarScript>().ID == StarID)
					{
						st.GetComponent<StarScript>().isActive = true;
						checkConst(ConstID);
					}
				}
			}
		}
    }

	void checkConst(int ConstID)
	{
		bool allIsFound = true;
		foreach(GameObject co in constel)
		{
			if (co.GetComponent<ConstScript>().ID == ConstID && co.GetComponent<ConstScript>().revealed == false)
			{
				stars = co.GetComponentsInChildren<Transform>();
				foreach(Transform st in stars)
				{
					if (st.tag == "Star" && st.GetComponent<StarScript>().isActive == false)
					{
						allIsFound = false;
					}
				}
				if (allIsFound)
				{
					co.GetComponent<ConstScript>().showLinkForever();
				}
			}
		}
	}

	public bool GetConstellation(int ConstID, int StarID)
    {
		foreach(GameObject co in constel)
		{
			if (co.GetComponent<ConstScript>().ID == ConstID)
			{
				stars = co.GetComponentsInChildren<Transform>();
				foreach(Transform st in stars)
				{
					if (st.GetComponent<StarScript>().ID == StarID)
					{
						if (st.GetComponent<StarScript>().isActive){return true;}
						else{return false;}
					}
				}
			}
		}
		return false;
    }
}
