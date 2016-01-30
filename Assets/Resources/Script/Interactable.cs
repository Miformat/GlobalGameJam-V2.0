using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour {

    public float waterLevelChange = 5f;
    public bool waterIsUp = false;

    public bool lightIsLighted = false;

    public bool openableIsOpen = false;
    
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeState(bool b)
    {
        Debug.Log(tag);
        switch (tag)
        {
            case "Openable":
                StartCoroutine(Open(b));
                break;
            case "Lightable":
                StartCoroutine(Light(b));
                break;
            case "InteractableWater":
                StartCoroutine(Water(b));
                break;
            case "InteractableRock":
                StartCoroutine(Rock(b));
                break;
        }
    }

    IEnumerator Open(bool b)
    {
        if(openableIsOpen != b)
        {
            if (openableIsOpen)
            {
                //on ferme
            }
            else
            {
                //on ouvre
            }
            lightIsLighted = b;
        }
        yield return null;
    }

    IEnumerator Light(bool b)
    {
        if(lightIsLighted != b)
        {
            if (lightIsLighted)
            {
                //on eteint
                while(GetComponent<Renderer>().material.color.r > 0.01f)
                {
                    GetComponent<Renderer>().material.color = new Color(GetComponent<Renderer>().material.color.r - 0.01f, GetComponent<Renderer>().material.color.g - 0.01f, GetComponent<Renderer>().material.color.b - 0.01f);
                    yield return new WaitForSeconds(0.01f);
                }
            }
            else
            {
                //on allume
                while (GetComponent<Renderer>().material.color.r < 0.99f)
                {
                    GetComponent<Renderer>().material.color = new Color(GetComponent<Renderer>().material.color.r + 0.01f, GetComponent<Renderer>().material.color.g + 0.01f, GetComponent<Renderer>().material.color.b + 0.01f);
                    yield return new WaitForSeconds(0.01f);
                }
            }
            lightIsLighted = b;
        }
        yield return null;
    }

    IEnumerator Water(bool b)
    {
        Debug.Log(b +" =? "+waterIsUp);
        if (b != waterIsUp)
        {
            float originLevel = transform.position.y;
            if(waterIsUp == true)
            {
                //l'eau baisse
                while(Mathf.Abs(transform.position.y - originLevel) < waterLevelChange)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
                    yield return new WaitForSeconds(0.01f);
                }
            }
            else
            {
                //l'eau monte
                while (Mathf.Abs(transform.position.y - originLevel) < waterLevelChange)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
                    yield return new WaitForSeconds(0.01f);
                }
            }
            waterIsUp = b;
        }
    }

    IEnumerator Rock(bool b)
    {
        if (b == false)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
        yield return null;
    }
}
