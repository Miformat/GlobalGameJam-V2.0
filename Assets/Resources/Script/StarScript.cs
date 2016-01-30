using UnityEngine;
using System.Collections;

public class StarScript : MonoBehaviour {

	public int ID;
	public bool isActive;
	SpriteRenderer sprRend;
	Color colorToTake;

	// Use this for initialization
	void Start () {
		isActive = false;
		sprRend = this.gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		colorToTake = sprRend.color;
		if (isActive){colorToTake.a = 1;}
		else{colorToTake.a = 0.3f;}
		sprRend.color = colorToTake;
	}
}
