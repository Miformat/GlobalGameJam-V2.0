using UnityEngine;
using System.Collections;

public class PartitionManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void doAction(string song)
	{
		switch (song) 
		{
			case "ONE":
				Debug.Log("PopTree");
				break;
			case "TWO":
				Debug.Log("PopRock");
				break;
			case "THREE":
				Debug.Log("PopWater");
				break;
		}
	}
}
