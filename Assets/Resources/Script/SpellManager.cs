using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpellManager : MonoBehaviour {

    static SpellManager instance;
    public AnimationCurve popCurve;
    public AnimationCurve depopCurve;

    public static SpellManager Instance
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

    public enum spellType
    {
        ELEMENT,
        PLANTE,
        PLANTE2,
        BUISSON,
        ROCK,
        TREE,
<<<<<<< HEAD
        ARTIFICE,
        BUGS,
        OISEAUX,
=======
		ARTIFICE,
		PAPILLON,
		LUCIOLE,
		OISEAUX,
>>>>>>> 0944472976dced3fe66b2c7bdecabd34d8b45788
        ALL
    }

    public GameObject elementPrefab;
    public GameObject plantePrefab;
    public GameObject plante2Prefab;

    public GameObject buissonPrefab;
    public List<GameObject> buissonModels;

    public GameObject rockPrefab;

    public GameObject treePrefab;
<<<<<<< HEAD
    public List<GameObject> treeModels;
=======
	public GameObject artificePrefab;
	public GameObject papillonPrefab;
	public GameObject luciolePrefab;
	public GameObject birdPrefab;
>>>>>>> 0944472976dced3fe66b2c7bdecabd34d8b45788

    public GameObject artificePrefab;
    public GameObject bugsPrefab;
    public GameObject birdPrefab;

    public GameObject[] GetPrefab(spellType type)
    {
        GameObject[] tab = new GameObject[2];

        switch (type)
        {
			case spellType.ELEMENT:
                tab[0] = elementPrefab;
				break;
			case spellType.PLANTE:
                tab[0] = plantePrefab;
				break;
			case spellType.PLANTE2:
                tab[0] = plante2Prefab;
				break;
			case spellType.BUISSON:
                tab[0] = buissonPrefab;
				break;
            case spellType.ROCK:
                tab[0] = rockPrefab;
                break;
            case spellType.TREE:
                tab[0] = treePrefab;
                break;
			case spellType.ARTIFICE:
                tab[0] = artificePrefab;
				break;
<<<<<<< HEAD
			case spellType.BUGS:
                tab[0] = bugsPrefab;
=======
			case spellType.PAPILLON:
				go = papillonPrefab;
				break;
			case spellType.LUCIOLE:
				go = luciolePrefab;
>>>>>>> 0944472976dced3fe66b2c7bdecabd34d8b45788
				break;
			case spellType.OISEAUX:
                tab[0] = birdPrefab;
				break;
        }

        return tab;
    }

    public GameObject GetTreeModel()
    {
        return treeModels[Random.Range(0, treeModels.Count)];
    }

    public GameObject GetBuissonModel()
    {
        return buissonModels[Random.Range(0, buissonModels.Count)];
    }
}
