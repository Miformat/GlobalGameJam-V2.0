using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interaction : MonoBehaviour {

    public float interactionRadius = 7f;

    public enum interactionType
    {
        OPEN,
        LIGHT,
        WATER,
        BIGROCK
    }

    Dictionary<interactionType, string> tags;

    // Use this for initialization
    void Start () {
        tags = new Dictionary<interactionType, string>();
        tags[interactionType.OPEN] = "Openable";
        tags[interactionType.LIGHT] = "Lightable";
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Interact(interactionType type, bool state)
    {
        Vector3 center = transform.position;

        Collider[] hitColliders = Physics.OverlapSphere(center, interactionRadius);

        foreach (Collider col in hitColliders)
        {
            /*if (type == SpellManager.spellType.ALL || col.tag == SpellManager.Instance.GetPrefab(type).tag)
            {
                if ((col.tag != "Player" && col.tag != "Ground"))
                {
                    Debug.Log(col.tag);
                    col.GetComponent<curveScript>().goDepop();
                }
            }*/
        }
    }
}
