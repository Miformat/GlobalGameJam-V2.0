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
        BUGS,
        OISEAUX,
		ARTIFICE,
		PAPILLON,
		LUCIOLE,
        ALL
    }

    public GameObject elementPrefab;
    public GameObject plantePrefab;
    public List<GameObject> planteModels;

    public GameObject plante2Prefab;
    public List<GameObject> plante2Models;

    public GameObject buissonPrefab;
    public List<GameObject> buissonModels;

    public GameObject rockPrefab;
    public List<GameObject> rockModels;

    public GameObject treePrefab;
    public List<GameObject> treeModels;

	public GameObject artificePrefab;
	public GameObject papillonPrefab;
	public GameObject luciolePrefab;
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
			case spellType.PAPILLON:
                tab[0] = papillonPrefab;
				break;
			case spellType.LUCIOLE:
                tab[0] = luciolePrefab;
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

    public GameObject GetRockModel()
    {
        return rockModels[Random.Range(0, rockModels.Count)];
    }

    public GameObject GetPlante1Model()
    {
        return planteModels[Random.Range(0, planteModels.Count)];
    }

    public GameObject GetPlante2Model()
    {
        return plante2Models[Random.Range(0, plante2Models.Count)];
    }
}
