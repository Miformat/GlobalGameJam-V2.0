using UnityEngine;
using System.Collections;

public class Invocation : MonoBehaviour {
    
    public float invocationRadius = 5f;

    public float detectionRadius = 5f;

    public int nbGeneration = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    public void Invoc(SpellManager.spellType type)
    {
        GameObject[] tab = SpellManager.Instance.GetPrefab(type);

        GameObject invocPrefab = tab[0];

        for (int i = 0; i < nbGeneration; i++)
        {
            Vector3 spawnPosition;
            float x, z;

            do
            {
                x = Random.Range(transform.position.x - invocationRadius, transform.position.x + invocationRadius);
                z = Random.Range(transform.position.z - invocationRadius, transform.position.z + invocationRadius);
                spawnPosition = new Vector3(x, transform.position.y, z);
            }
            while (Vector3.Distance(spawnPosition,transform.position)< detectionRadius);
            
            GameObject go = Instantiate(invocPrefab, spawnPosition, Quaternion.identity) as GameObject;

            /*if (tab[1])
            {
                GameObject model = Instantiate(tab[1], spawnPosition, Quaternion.identity) as GameObject;
                model.transform.parent = go.transform;
            }*/

            CreateModel(type, go);

            go.AddComponent<curveScript>();

            Vector3 center = go.transform.position;

            Collider[] hitColliders = Physics.OverlapSphere(center, detectionRadius);

            bool canExist = true;

            foreach (Collider col in hitColliders)
            {
                if (col.tag != "Ground" && col.gameObject != go)
                {
                    canExist = false;
                }
            }

            if (!canExist)
            {
                Destroy(go);
            }
        }
    }

    void CreateModel(SpellManager.spellType type, GameObject go)
    {
        GameObject model = null;

        switch (type)
        {
            case SpellManager.spellType.ELEMENT:
                
                break;
            case SpellManager.spellType.PLANTE:
                
                break;
            case SpellManager.spellType.PLANTE2:
                
                break;
            case SpellManager.spellType.BUISSON:
                model = SpellManager.Instance.GetBuissonModel();
                break;
            case SpellManager.spellType.ROCK:
                model = SpellManager.Instance.GetRockModel();
                break;
            case SpellManager.spellType.TREE:
                model = SpellManager.Instance.GetTreeModel();
                break;
            case SpellManager.spellType.ARTIFICE:
                
                break;
            case SpellManager.spellType.BUGS:
                
                break;
            case SpellManager.spellType.OISEAUX:
                
                break;
        }

        if (model)
        {
            model = Instantiate(model, go.transform.position, Quaternion.identity) as GameObject;
            model.transform.parent = go.transform;

            float randRotation = Random.Range(0f, 360f);

            model.transform.localEulerAngles = new Vector3(model.transform.localEulerAngles.x, randRotation, model.transform.localEulerAngles.z);

            float randSize = Random.Range(model.transform.localScale.x * 0.7f, model.transform.localScale.x * 1.5f);

            model.transform.localScale = Vector3.one * randSize;
                
        }
        
    }

    public void Uninvoc(SpellManager.spellType type)
    {
        AudioClip aC = null;
        
        Vector3 center = transform.position;

        Collider[] hitColliders = Physics.OverlapSphere(center, invocationRadius+1f);
        
        foreach (Collider col in hitColliders)
        {
            if (type == SpellManager.spellType.ALL || col.tag == SpellManager.Instance.GetPrefab(type)[0].tag)
            {
                if((col.tag != "Player" && col.tag != "Ground") && col.GetComponent<curveScript>())
                {
                    switch (col.tag)
                    {
                        case "Rock":
                            aC = SoundManager.Instance.rockDestroy;
                            break;
                        case "Tree":
                            aC = SoundManager.Instance.treeDestroy;
                            break;
                        case "Buisson":
                            aC = SoundManager.Instance.foliageDestroy;
                            break;
                    }
                    //Debug.Log(col.tag);
                    if (aC)
                    {
                        AudioSource.PlayClipAtPoint(aC, col.transform.position);
                    }

                    col.GetComponent<curveScript>().goDepop();
                }
            }
        }
    }
}
