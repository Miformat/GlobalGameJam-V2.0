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
        ROCK,
        TREE,
		ARTIFICE,
        ALL
    }

	public GameObject elementPrefab;
    public GameObject rockPrefab;
    public GameObject treePrefab;
	public GameObject artificePrefab;

    public GameObject GetPrefab(spellType type)
    {
        GameObject go = null;

        switch (type)
        {
			case spellType.ELEMENT:
				go = elementPrefab;
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
        }

        return go;
    }
}
