using UnityEngine;
using System.Collections;
using System.Collections.Generic;
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
        constellations[constellationType.INTERACTIONS].Add("retirerGrosRocher");

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
		switch (song) 
		{
		case "element":
                Element();
			break;
		case "plante":
                Plante();
		Debug.Log("plante");
			break;
		case "destroyplante":
                DestroyPlante();
		Debug.Log("destroyplante");
			break;
		case "plante2":
                PlanteDeux();
			Debug.Log("plante2");
			break;
		case "destroyplante2":
                DestroyPlanteDeux();
			Debug.Log("destroyplante2");
			break;
		case "empreintesPlantes":
                EmpreintesPlantes();
			Debug.Log("empreintesPlantes");
			break;
		case "petitRocher":
                PetitRocher();
			Debug.Log("petitRocher");
			break;
		case "destroypetitRocher":
                DestroyPetitRocher();
			Debug.Log("destroypetitRocher");
			break;
		case "papillon":
                Papillon();
			Debug.Log("papillon");
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
			Debug.Log("arbres");
			break;
		case "destroyArbres":
                DestroyArbres();
			Debug.Log("destroyArbres");
			break;
		case "buissons":
                Buissons();
			Debug.Log("buissons");
			break;
		case "destroybuissons":
                DestroyBuissons();
			Debug.Log("destroybuissons");
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
			Debug.Log("oiseaux");
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

        UnlockSong(song);

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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    private void DestroyBuissons()
    {
        throw new NotImplementedException();
    }

    private void Buissons()
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    private void PlanteDeux()
    {
        throw new NotImplementedException();
    }

    private void DestroyPlante()
    {
        throw new NotImplementedException();
    }

    private void Plante()
    {
        throw new NotImplementedException();
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

    void UnlockSong(string song)
    {
        if (!discoveredSongs[song])
        {
            discoveredSongs[song] = true;
            UpdateConstellations();
        }
    }

    void UpdateConstellations()
    {

    }

    public List<bool> GetConstellation(constellationType type)
    {
        List<bool> stars = new List<bool>();

        foreach(string song in constellations[type])
        {
            stars.Add(discoveredSongs[song]);
        }

        return stars;
    }
}
