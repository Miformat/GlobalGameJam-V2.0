using UnityEngine;
using System.Collections;

public class ConstScript : MonoBehaviour {

	public int ID;
	public float timeRevealed;
	public bool revealed;
	float timer;
	Transform[] children;

	// Use this for initialization
	void Start () {
		revealed = false;
		timer = 0;
		children = this.gameObject.GetComponentsInChildren<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (revealed == false) 
		{
			if (timer == timeRevealed)
			{
				foreach(Transform go in children)
				{
					if (go.tag == "Link"){go.GetComponent<SpriteRenderer>().enabled = true;}
				}
			}
			if (timer > 0)
			{
				timer -= Time.deltaTime;
				if (timer < 0)
				{
					foreach(Transform go in children)
					{
						if (go.tag == "Link"){go.GetComponent<SpriteRenderer>().enabled = false;}
					}
				}
			}
		}
	}

	public void activeStar(int starID)
	{
		foreach(Transform go in this.gameObject.GetComponentsInChildren<Transform>())
		{
			if (go.GetComponent<StarScript>().ID == starID){go.GetComponent<StarScript>().isActive = true;}
		}
	}

	public void showLink()
	{
		timer = timeRevealed;
	}

	public void showLinkForever()
	{
		revealed = true;
		foreach(Transform go in children)
		{
			if (go.tag == "Link"){go.GetComponent<SpriteRenderer>().enabled = true;}
		}
	}
}
