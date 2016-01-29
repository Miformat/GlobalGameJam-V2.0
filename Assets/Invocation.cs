using UnityEngine;
using System.Collections;

public class Invocation : MonoBehaviour {

    public GameObject invocPrefab;

    public float invocationRadius = 5f;

    public float detectionRadius = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.A))
        {
            Invoc();
        }
	}

    void Invoc()
    {
        Vector3 spawnPosition;
        float x = Random.Range(transform.position.x - invocationRadius, transform.position.x + invocationRadius);
        float z = Random.Range(transform.position.z - invocationRadius, transform.position.z + invocationRadius);

        spawnPosition = new Vector3(x, invocPrefab.transform.localScale.y / 2, z);

        GameObject go = Instantiate(invocPrefab, spawnPosition, Quaternion.identity) as GameObject;
        
        Vector3 center = go.transform.position;
        
        Collider[] hitColliders = Physics.OverlapSphere(center, detectionRadius);

        bool canExist = true;

        foreach(Collider col in hitColliders)
        {
            Debug.Log(col.tag);

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
