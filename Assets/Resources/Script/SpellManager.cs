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
		ARTIFICE,
		PAPILLON,
		LUCIOLE,
		OISEAUX,
        ALL
    }

	public GameObject elementPrefab;
	public GameObject plantePrefab;
	public GameObject plante2Prefab;
	public GameObject buissonPrefab;
    public GameObject rockPrefab;
    public GameObject treePrefab;
	public GameObject artificePrefab;
	public GameObject papillonPrefab;
	public GameObject luciolePrefab;
	public GameObject birdPrefab;

    public GameObject GetPrefab(spellType type)
    {
        GameObject go = null;

        switch (type)
        {
			case spellType.ELEMENT:
				go = elementPrefab;
				break;
			case spellType.PLANTE:
				go = plantePrefab;
				break;
			case spellType.PLANTE2:
				go = plante2Prefab;
				break;
			case spellType.BUISSON:
				go = buissonPrefab;
				break;
            case spellType.ROCK:
                go = rockPrefab;
                break;
            case spellType.TREE:
                go = treePrefab;
                break;
			case spellType.ARTIFICE:
				go = artificePrefab;
				break;
			case spellType.PAPILLON:
				go = papillonPrefab;
				break;
			case spellType.LUCIOLE:
				go = luciolePrefab;
				break;
			case spellType.OISEAUX:
				go = birdPrefab;
				break;
        }

        return go;
    }
}
