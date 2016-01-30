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
		        Debug.Log("element");
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
			Debug.Log("feuArtifice");
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
	}

    private void Nuit()
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    private void MeteoClaire()
    {
        throw new NotImplementedException();
    }

    private void Boussole()
    {
        throw new NotImplementedException();
    }

    private void Neige()
    {
        throw new NotImplementedException();
    }

    private void Pluie()
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
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
