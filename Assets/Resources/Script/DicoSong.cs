using UnityEngine;
using System.Collections;

public class DicoSong : MonoBehaviour {

	public string[][] tabSong;

	// Use this for initialization
	void Start () {
		tabSong = new string[][]
		{
			//new string[]{note, note......, CODE},
			new string[]{"a", "a", "a", "ONE"},
			new string[]{"b", "b", "b", "TWO"},
			new string[]{"c", "c", "c", "THREE"},
		};
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
