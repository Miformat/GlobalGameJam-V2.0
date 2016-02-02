using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour {

    public float waterLevelChange = 5f;
    public bool waterIsUp = false;

    public bool lightIsLighted = false;

    public bool openableIsOpen = false;

    public bool noLeaves = true;

    public bool noFlower = true;

    public Material waterMat;

    // Use this for initialization
    void Start() {

        if (tag == "DeadTree")
        {

            GetComponent<Renderer>().material.SetFloat("_Flowers", 0f);
            GetComponent<Renderer>().material.SetFloat("_Leaves", 0f);
        }

        if (tag == "InteractableWater" || tag == "DeadTree")
        {
            GetComponent<Renderer>().material = waterMat;
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeState(Interaction.interactionType type, bool b)
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
            case "DeadTree":
                if(type == Interaction.interactionType.LEAVES)
                {
                    StartCoroutine(Leaves(b));
                }
                else
                {
                    StartCoroutine(Flower(b));
                }
                break;
        }
    }

    IEnumerator Open(bool b)
    {
        if (b == false)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
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

    IEnumerator Leaves(bool b)
    {
        if (b == true && noLeaves == true)
        {
            while (GetComponent<Renderer>().material.GetFloat("_Leaves") < 1f)
            {
                GetComponent<Renderer>().material.SetFloat("_Leaves", GetComponent<Renderer>().material.GetFloat("_Leaves") + 0.01f);
                yield return new WaitForSeconds(0.01f);

            }

            noLeaves = false;
        }
    }

    IEnumerator Flower(bool b)
    {
        if (b == true && noFlower== true)
        {
            while (GetComponent<Renderer>().material.GetFloat("_Flowers") < 1f)
            {
                GetComponent<Renderer>().material.SetFloat("_Flowers", GetComponent<Renderer>().material.GetFloat("_Flowers") + 0.01f);
                yield return new WaitForSeconds(0.01f);

            }

            noFlower = false;
        }
    }
}
