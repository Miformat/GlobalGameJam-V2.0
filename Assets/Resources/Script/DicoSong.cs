using UnityEngine;
using System.Collections;

public class DicoSong : MonoBehaviour {

	public string[][] tabSong;

	// Use this for initialization
	void Awake () {
		tabSong = new string[][]
		{
			//new string[]{note, note......, CODE},
			/*new string[]{"a", "a", "a", "ONE"},
			new string[]{"b", "b", "b", "TWO"},
			new string[]{"c", "c", "c", "THREE"},*/

            new string[]{"z", "z", "element"},
            new string[]{"z", "q", "plante"},
            new string[]{"z", "d", "plante2"},
            new string[]{"q", "z", "destroyplante"},
            new string[]{"d", "z", "destroyplante2"},

            new string[]{"z", "s", "s" , "empreintesPlantes"},
            new string[]{"q", "z", "s" , "petitRocher"},
            new string[]{"q", "z", "s" , "destroypetitRocher"},
            new string[]{"q", "d", "q" , "papillon"},
			new string[]{"d", "q", "d" , "luciole"},
            new string[]{"s", "d", "q" , "ouvrir"},
            new string[]{"d", "q", "s" , "fermer"},

            new string[]{"z", "z", "q" , "q" , "arbres"},
            new string[]{"q", "q", "z" , "z" , "destroyArbres"},
            new string[]{"z", "q", "z" , "d" , "buissons"},
            new string[]{"d", "z", "q" , "z" , "destroybuissons"},
            new string[]{"z", "q", "s" , "d" , "constellations"},
            new string[]{"z", "s", "z" , "z" , "feuArtifice"},
            new string[]{"q", "s", "d" , "s" , "meteo4"},
            new string[]{"q", "d", "d" , "z" , "couleur"},
            new string[]{"s", "q", "s" , "d" , "pluie"},
            new string[]{"s", "d", "s" , "q" , "neige"},
            new string[]{"d", "q", "z" , "s" , "boussole"},
            new string[]{"d", "s", "q" , "s" , "meteoClaire"},

            new string[]{"z", "z", "s" , "z" , "z" , "voler"},
            new string[]{"z", "s", "q" , "d" , "z" , "fleurir"},
            new string[]{"z", "d", "q" , "s" , "z" , "feuillir"},
            new string[]{"z", "d", "q" , "d" , "q" , "eteindre"},
            new string[]{"q", "s", "d" , "s" , "q" , "oiseaux"},
            new string[]{"q", "d", "q" , "d" , "z" , "allumer"},
            new string[]{"d", "s", "q" , "d" , "s" , "auroreBoreale"},

            new string[]{"z", "s", "q" , "z" , "s" , "d" , "assecher"},
            new string[]{"q", "s", "d" , "q" , "s" , "d" , "jour"},
            new string[]{"q", "s", "d" , "d" , "s" , "q" , "credit"},
            new string[]{"s", "s", "z" , "z" , "q" , "q" , "retirerGrosRocher"},
            new string[]{"s", "s", "q" , "d" , "s" , "s" , "effacer"},
            new string[]{"d", "s", "z" , "q" , "s" , "z" , "remplirEau"},
            new string[]{"d", "s", "q" , "d" , "s" , "q" , "nuit"},
        };
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
