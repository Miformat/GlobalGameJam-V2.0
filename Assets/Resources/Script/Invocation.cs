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
        if (Input.GetKeyDown(KeyCode.A))
        {
            Invoc(SpellManager.spellType.ROCK);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Uninvoc(SpellManager.spellType.ROCK);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            Invoc(SpellManager.spellType.TREE);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Uninvoc(SpellManager.spellType.TREE);
        }
    }

    void Invoc(SpellManager.spellType type)
    {
        GameObject invocPrefab = SpellManager.Instance.GetPrefab(type);

        for (int i = 0; i < nbGeneration; i++)
        {
            Vector3 spawnPosition;
            float x, z;

            do
            {
                x = Random.Range(transform.position.x - invocationRadius, transform.position.x + invocationRadius);
                z = Random.Range(transform.position.z - invocationRadius, transform.position.z + invocationRadius);
                spawnPosition = new Vector3(x, invocPrefab.transform.localScale.y / 2, z);
            }
            while (Vector3.Distance(spawnPosition,transform.position)< detectionRadius);


            GameObject go = Instantiate(invocPrefab, spawnPosition, Quaternion.identity) as GameObject;

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

    void Uninvoc(SpellManager.spellType type)
    {
        Vector3 center = transform.position;

        Collider[] hitColliders = Physics.OverlapSphere(center, invocationRadius+1f);
        
        foreach (Collider col in hitColliders)
        {
            if (col.tag == SpellManager.Instance.GetPrefab(type).tag)
            {
                Destroy(col.gameObject);
            }
        }
    }
}
