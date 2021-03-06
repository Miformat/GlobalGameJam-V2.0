﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interaction : MonoBehaviour {

    public float interactionRadius = 7f;

    public enum interactionType
    {
        OPEN,
        LIGHT,
        WATER,
        BIGROCK,
        LEAVES,
        FLOWER
    }

    public static Dictionary<interactionType, string> tags;

    // Use this for initialization
    void Start () {
        tags = new Dictionary<interactionType, string>();
        tags[interactionType.OPEN] = "Openable";
        tags[interactionType.LIGHT] = "Lightable";
        tags[interactionType.WATER] = "InteractableWater";
        tags[interactionType.BIGROCK] = "InteractableRock";
        tags[interactionType.LEAVES] = "DeadTree";
        tags[interactionType.FLOWER] = "DeadTree";
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Interact(interactionType.LIGHT, true);
        }
    }

    public void Interact(interactionType type, bool state)
    {
        Vector3 center = transform.position;

        Collider[] hitColliders = Physics.OverlapSphere(center, interactionRadius);

        foreach (Collider col in hitColliders)
        {
            //Debug.Log(col.tag + " | " + tags[type]);
            if(col.tag == tags[type])
            {
                col.GetComponent<Interactable>().ChangeState(type, state);
            }
        }
    }
}
