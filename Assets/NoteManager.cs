using UnityEngine;
using System.Collections;

public class NoteManager : MonoBehaviour {

	public string[] noteSheet;
	public float reactionTime;
	public int maxSize;
	public float timer;
	string keyPressed;
	int index;
	string firstElem;
	int sizeTab;

	string[][] dico;
	PartitionManager partition;

	// Use this for initialization
	void Start () {
		sizeTab = 0;
		timer = 0;
		index = 0;
		noteSheet = new string[maxSize];
		dico = GameObject.FindGameObjectWithTag ("Dico").GetComponent<DicoSong>().tabSong;
		partition = GameObject.FindGameObjectWithTag ("Partition").GetComponent<PartitionManager>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		firstElem = noteSheet [0];
		if ((timer < 0 && sizeTab > 0)|| sizeTab == maxSize)
		{
			executePartition();
		}
		if (Input.anyKeyDown) 
		{
			keyPressed = Input.inputString;
			if (keyPressed != "" && keyPressed != null)
			{
				timer = reactionTime;
				noteSheet[index] = keyPressed;
				index++;
				sizeTab++;
			}
		}
	}

	void executePartition()
	{
		int nb = 0;
		/*foreach (string str in noteSheet) 
		{
			Debug.Log("Elem " + nb + " : " + str);
			nb++;
		}*/
		bool match;
		foreach (string[] str in dico) 
		{
			match = true;
			if (str.Length-1 == sizeTab)
			{
				for(int i = 0; i < sizeTab; i++)
				{
					if (noteSheet[i] != str[i]){match = false;}
				}
				if (match)
				{
					string code = str[str.Length-1];
					Debug.Log("Match = " + code);
					partition.doAction(code);
				}
			}
		}
		index = 0;
		timer = 0;
		sizeTab = 0;
		noteSheet = new string[maxSize];
	}
}
