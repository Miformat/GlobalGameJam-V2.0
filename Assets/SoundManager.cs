using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

    static SoundManager instance;

    public static SoundManager Instance
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
    public AudioClip rockDestroy;
    public AudioClip treeDestroy;
    public AudioClip foliageDestroy;
    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
