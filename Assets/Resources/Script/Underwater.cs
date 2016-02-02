using UnityEngine;
using System.Collections;

public class Underwater : MonoBehaviour {
	
	//This script enables underwater effects. Attach to main camera.
	
	//Define variable
	float underwaterLevel;// = -16;
	GameObject lac;

	//The scene's default fog settings
	private bool defaultFog;
	private Color defaultFogColor;
	private float defaultFogDensity;
	private Material defaultSkybox;
	private Material noSkybox;
	public Color underWaterColor;
	
	void Start () {
		//Set the background color
		lac = GameObject.Find ("Lac");
		defaultFog = RenderSettings.fog;
		defaultFogColor = RenderSettings.fogColor;
		defaultFogDensity = RenderSettings.fogDensity;
		defaultSkybox = RenderSettings.skybox;
		//Camera.main.backgroundColor = new Color(0, 0.4f, 0.7f, 1);
	}
	
	void Update () {
		underwaterLevel = lac.transform.position.y - 4;
		if (this.gameObject.transform.parent.position.y < underwaterLevel)
		{
			RenderSettings.fog = true;
			/*RenderSettings.fogColor = underWaterColor;//new Color(0, 0.4f, 0.7f, 0.6f);
			RenderSettings.fogDensity = 0.01f;
			RenderSettings.fogStartDistance = -50;
			RenderSettings.fogEndDistance = 100;
			RenderSettings.skybox = noSkybox;*/
		}
		else
		{
			RenderSettings.fog = defaultFog;
			RenderSettings.fogColor = defaultFogColor;
			RenderSettings.fogDensity = defaultFogDensity;
			RenderSettings.skybox = defaultSkybox;
		}
	}
}