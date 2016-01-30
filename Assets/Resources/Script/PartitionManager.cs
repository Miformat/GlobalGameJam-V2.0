using UnityEngine;
using System.Collections;
using System;

public class PartitionManager : MonoBehaviour {

    static PartitionManager instance;

    public static PartitionManager Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void doAction(string song)
	{
		switch (song) 
		{
		case "element":
                Element();
			break;
		case "plante":
                Plante();
			break;
		case "destroyplante":
                DestroyPlante();
			break;
		case "plante2":
                PlanteDeux();
			break;
		case "destroyplante2":
                DestroyPlanteDeux();
			break;
		case "empreintesPlantes":
                EmpreintesPlantes();
			break;
		case "petitRocher":
                PetitRocher();
			break;
		case "destroypetitRocher":
                DestroyPetitRocher();
			break;
		case "papillon":
                Papillon();
			break;
		case "ouvrir":
                Ouvrir();
			Debug.Log("ouvrir");
			break;
		case "fermer":
                Fermer();
			Debug.Log("fermer");
			break;
		case "arbres":
                Arbres();
			break;
		case "destroyArbres":
                DestroyArbres();
			break;
		case "buissons":
                Buissons();
			break;
		case "destroybuissons":
                DestroyBuissons();
			break;
		case "constellations":
                Constellations();
			Debug.Log("constellations");
			break;
		case "feuArtifice":
                FeuArtifice();
			break;
		case "meteo4":
                MeteoQuatre();
			Debug.Log("meteo4");
			break;
		case "couleur":
                Couleur();
			Debug.Log("couleur");
			break;
		case "pluie":
                Pluie();
			Debug.Log("pluie");
			break;
		case "neige":
                Neige();
			Debug.Log("neige");
			break;
		case "boussole":
                Boussole();
			Debug.Log("boussole");
			break;
		case "meteoClaire":
                MeteoClaire();
			Debug.Log("meteoClaire");
			break;
		case "voler":
                Voler();
			Debug.Log("voler");
			break;
		case "fleurir":
                Fleurir();
			Debug.Log("fleurir");
			break;
		case "feuillir":
                Feuillir();
			Debug.Log("feuillir");
			break;
		case "eteindre":
                Eteindre();
			Debug.Log("eteindre");
			break;
		case "oiseaux":
                Oiseaux();
			break;
		case "allumer":
                Allumer();
			Debug.Log("allumer");
			break;
		case "auroreBoreale":
                AuroreBoreale();
			Debug.Log("auroreBoreale");
			break;
		case "assecher":
                Assecher();
			Debug.Log("assecher");
			break;
		case "jour":
                Jour();
			Debug.Log("jour");
			break;
		case "credit":
                Credit();
			Debug.Log("credit");
			break;
		case "retirerGrosRocher":
                RetirerGrosRocher();
			Debug.Log("retirerGrosRocher");
			break;
		case "effacer":
                Effacer();
			Debug.Log("effacer");
			break;
		case "remplirEau":
                RemplirEau();
			Debug.Log("remplirEau");
			break;
		case "nuit":
                Nuit();
			Debug.Log("nuit");
			break;
		}
	}

    private void Nuit()
    {
        MeteoManager.Instance.SetDay(false);
    }

    private void RemplirEau()
    {
        throw new NotImplementedException();
    }

    private void RetirerGrosRocher()
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    private void AuroreBoreale()
    {
        throw new NotImplementedException();
    }

    private void Allumer()
    {
        throw new NotImplementedException();
    }

    private void Oiseaux()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.OISEAUX);
    }

    private void Eteindre()
    {
        throw new NotImplementedException();
    }

    private void Feuillir()
    {
        throw new NotImplementedException();
    }

    private void Fleurir()
    {
        throw new NotImplementedException();
    }

    private void Voler()
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    private void FeuArtifice()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.ARTIFICE);
    }

    private void Constellations()
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    private void Ouvrir()
    {
        throw new NotImplementedException();
    }

    private void Papillon()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.BUGS);
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
}
