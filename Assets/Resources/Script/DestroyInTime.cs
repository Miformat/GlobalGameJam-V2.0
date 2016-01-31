using UnityEngine;
using System.Collections;

public class DestroyInTime : MonoBehaviour {

	public float timer;
	public bool dontDestroyIfVisible;
	public bool betterDisable;
	bool visible;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (dontDestroyIfVisible){visible = this.gameObject.GetComponent<Renderer> ().isVisible;}
		timer -= Time.deltaTime;
		if (timer < 0)
		{
			if(dontDestroyIfVisible)
			{
				if (!visible){Destroy(this.gameObject);}
			}
			else if (betterDisable)
			{
				this.gameObject.SetActive(false);
			}
			else
			{
				Destroy(this.gameObject);
			}
		}
	}
}
