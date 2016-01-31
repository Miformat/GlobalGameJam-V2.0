using UnityEngine;
using System.Collections;

public class NoteManager : MonoBehaviour {

    static NoteManager instance;

    public static NoteManager Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        instance = this;
    }

    public string[] noteSheet;
	public float reactionTime;
	public int maxSize;
	public float timer;
	string keyPressed;
	int index;
	int sizeTab;
	GameObject player;
	GameObject papaNote;

	GameObject notez;
	GameObject noteq;
	GameObject notes;
	GameObject noted;
	GameObject note1;
	GameObject note2;

    Animator animator;

	string[][] dico;
	PartitionManager partition;

    CharacterController cC;

	// Use this for initialization
	void Start () {
		notez = Resources.Load ("Prefab/Note-z") as GameObject;
		noteq = Resources.Load ("Prefab/Note-q") as GameObject;
		notes = Resources.Load ("Prefab/Note-s") as GameObject;
		noted = Resources.Load ("Prefab/Note-d") as GameObject;
		note1 = Resources.Load ("Prefab/Note-1") as GameObject;
		note2 = Resources.Load ("Prefab/Note-2") as GameObject;
		player = GameObject.FindGameObjectWithTag ("Player");
		papaNote = new GameObject();
		papaNote.name = "PapaNote";
		sizeTab = 0;
		timer = 0;
		index = 0;
		noteSheet = new string[maxSize];
		dico = GameObject.FindGameObjectWithTag ("Dico").GetComponent<DicoSong>().tabSong;
		partition = GameObject.FindGameObjectWithTag ("Partition").GetComponent<PartitionManager>();

        animator = FindObjectOfType<PlayerController>().animator;

        cC = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		if ((timer < 0 && sizeTab > 0)|| sizeTab == maxSize)
		{
            animator.SetLayerWeight(1, 0);
            animator.SetBool("sing", false);
            executePartition();
		}
		if (Input.anyKeyDown && cC.isGrounded) 
		{
			keyPressed = Input.inputString;
			if (keyPressed != "" && keyPressed != null)
            {
                animator.SetLayerWeight(1, 1);
                animator.SetBool("sing", true);
                timer = reactionTime;
				noteSheet[index] = keyPressed;
				index++;
				sizeTab++;
				showNote(keyPressed);
			}
		}
	}

	void showNote(string str)
	{
		int rnd = Random.Range (0, 2);
		GameObject toPop;
		switch (str)
		{
		case "z":
			toPop = notez;
			break;
		case "q":
			toPop = noteq;
			break;
		case "s":
			toPop = notes;
			break;
		case "d":
			toPop = noted;
			break;
		default:
			if (rnd == 0){toPop = note1;}
			else{toPop = note2;}
			break;
		}
		toPop = Instantiate (toPop, player.transform.position, Quaternion.identity) as GameObject;
		toPop.transform.parent = papaNote.transform;
	}

	void executePartition()
	{
		bool match;
		foreach(Transform TS in papaNote.GetComponentsInChildren<Transform>())
		{
			if (TS != papaNote.transform){TS.GetComponent<notePopScript>().sizeDown = true;}
		}

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
