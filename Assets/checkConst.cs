using UnityEngine;
using System.Collections;

public class checkConst : MonoBehaviour {

    GameObject[] constTab;
    public bool isOk;
    bool checking;
	// Use this for initialization
	void Start () {
        isOk = false;
        constTab = GameObject.FindGameObjectsWithTag("Const");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isOk == false)
        {
            checking = true;
            foreach (GameObject go in constTab)
            {
                if (go.GetComponent<ConstScript>().revealed == false) { checking = false; }
            }
            if (checking)
            {
                isOk = true;
            }
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
	}
}
