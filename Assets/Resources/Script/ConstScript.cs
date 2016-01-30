using UnityEngine;
using System.Collections;

public class ConstScript : MonoBehaviour {

	public int ID;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void activeStar(int starID)
	{
		foreach(Transform go in this.gameObject.GetComponentsInChildren<Transform>())
		{
			if (go.GetComponent<StarScript>().ID == starID){go.GetComponent<StarScript>().isActive = true;}
		}
	}
}
