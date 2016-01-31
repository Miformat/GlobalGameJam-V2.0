using UnityEngine;
using System.Collections;

public class colorScript : MonoBehaviour {

	public float radius;
	TrackManager TM;
	// Use this for initialization
	void Start () {
		TM = FindObjectOfType<TrackManager>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void colorAll () 
	{
		GameObject[] allAround = GameObject.FindObjectsOfType<GameObject>();
		float r;
		float g;
		float b;
		Color newColor;
		foreach(GameObject go in allAround)
        {
            if (Vector3.Distance(this.gameObject.transform.position, go.transform.position) < radius && go.layer == 8)
            {
                Material mat = go.GetComponent<MeshRenderer>().material;
				if (mat)
				{

					TM.isColor = true;
					r = Random.Range (0.0f,1.0f);
					g = Random.Range (0.0f,1.0f);
					b = Random.Range (0.0f,1.0f);
					newColor = new Color (r,g,b);
					mat.SetColor("_DiffuseColor", newColor);
				}
			}
		}
	}
}
