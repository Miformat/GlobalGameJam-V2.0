using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MeteoManager : MonoBehaviour {

    static MeteoManager instance;

    public static MeteoManager Instance
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

    public enum Weather
    {
        CLEAR,
        RAIN,
        SNOW,
        SUNNY,
        OTHER,
    }

    public List<Material> materials;

    public Weather currentWeather;
    public bool day;

    Material skybox;
    Light mainLight;

    public Color colorDay = new Color(1f, 0.86f, 0.82f);
    public Color colorDayRain = new Color(0.62f, 0.81f, 0.83f);
    public Color colorDaySnow = new Color(0.83f, 0.76f, 1f);
    public Color colorDayOther = new Color(0.83f, 0.76f, 1f);

    public Color colorNight = new Color(0.4f, 0.22f, 0.56f);
    public Color colorNightRain = new Color(1f, 0.86f, 0.82f);
    public Color colorNightSnow = new Color(1f, 0.86f, 0.82f);
    public Color colorNightOther = new Color(1f, 0.86f, 0.82f);

    public GameObject aurore;

    GameObject rain;
    GameObject snow;
    GameObject other;

    TrackManager tM;

    GameObject[] waterZones;

    // Use this for initialization
    void Start () {

        waterZones = GameObject.FindGameObjectsWithTag("InteractableWater");

        currentWeather = Weather.CLEAR;
        day = true;

        skybox = RenderSettings.skybox;

        skybox.SetFloat("_DayToNight", 0f);
        skybox.SetFloat("_RainToSnow", 0f);
        skybox.SetFloat("_NormalToRainSnow", 0f);
        skybox.SetFloat("_RainSnowToSpecial", 0f);

        mainLight = FindObjectOfType<Light>();

        foreach (Material m in materials)
        {
            m.SetFloat("_Snow", 0f);
        }

        rain = GameObject.Find("PS_Rain");
        snow = GameObject.Find("PS_Snowflakes");
        other = GameObject.Find("PS_weather");

        rain.SetActive(false);
        snow.SetActive(false);
        other.SetActive(false);

        tM = FindObjectOfType<TrackManager>();

        SetAurore(false);
    }

    public void SwitchWeather(Weather w)
    {
        currentWeather = w;
        
        switch (currentWeather)
        {
            case Weather.CLEAR:
                StartCoroutine(ChangeSkyboxValue("_NormalToRainSnow", 0f));
                StartCoroutine(ChangeSkyboxValue("_RainToSnow", 0f));
                StartCoroutine(ChangeSkyboxValue("_RainSnowToSpecial", 0f)); 
                 SetSnow(false);
                break;
            case Weather.RAIN:
                StartCoroutine(ChangeSkyboxValue("_NormalToRainSnow", 1f));
                StartCoroutine(ChangeSkyboxValue("_RainToSnow", 0f));
                StartCoroutine(ChangeSkyboxValue("_RainSnowToSpecial", 0f));
                SetSnow(false);
                break;
            case Weather.SNOW:
                StartCoroutine(ChangeSkyboxValue("_NormalToRainSnow", 1f));
                StartCoroutine(ChangeSkyboxValue("_RainToSnow", 1f));
                StartCoroutine(ChangeSkyboxValue("_RainSnowToSpecial", 0f));
                SetSnow(true);
                break;
            case Weather.OTHER:
                StartCoroutine(ChangeSkyboxValue("_NormalToRainSnow", 1f));
                StartCoroutine(ChangeSkyboxValue("_RainToSnow", 0f));
                StartCoroutine(ChangeSkyboxValue("_RainSnowToSpecial", 1f));
                SetSnow(false);
                break;
        }

        tM.meteo = currentWeather;

        UpdateColor();
    }

    public void SetSnow(bool b)
    {
        foreach (GameObject waterZone in waterZones)
        {
            waterZone.GetComponent<Collider>().isTrigger = !b;
        }
    }

    public void SetDay(bool b)
    {
        day = b;

        StartCoroutine(ChangeSkyboxValue("_DayToNight", day ? 0f : 1f));

        UpdateColor();

        tM.isDay = day;
    }

    void UpdateColor()
    {
        switch (currentWeather)
        {
            case Weather.CLEAR:
                SetAurore(false);
                rain.SetActive(false);
                snow.SetActive(false);
                other.SetActive(false);
                mainLight.color = day ? colorDay : colorNight;
                break;
            case Weather.RAIN:
                rain.SetActive(true);
                snow.SetActive(false);
                other.SetActive(false);
                mainLight.color = day ? colorDayRain : colorNightRain;
                break;
            case Weather.SNOW:
                rain.SetActive(false);
                snow.SetActive(true);
                other.SetActive(false);
                mainLight.color = day ? colorDaySnow : colorNightSnow;
                break;
            case Weather.OTHER:
                rain.SetActive(false);
                snow.SetActive(false);
                other.SetActive(true);
                mainLight.color = day ? colorDayOther : colorNightOther;
                break;

        }
    }

    IEnumerator ChangeSkyboxValue(string paramName, float value)
    {
        bool snowing = paramName == "_RainToSnow";

        float actualValue = skybox.GetFloat(paramName);
        
        if (actualValue > value)
        {
            while (skybox.GetFloat(paramName) > value)
            {
                actualValue -= 0.1f;
                skybox.SetFloat(paramName, actualValue);
                
                if (snowing)
                {
                    foreach (Material m in materials)
                    {
                        m.SetFloat("_Snow", actualValue);
                    }
                }

                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            while (skybox.GetFloat(paramName) < value)
            {
                actualValue += 0.1f;
                skybox.SetFloat(paramName, actualValue);

                
                if (snowing)
                {
                    foreach (Material m in materials)
                    {
                        m.SetFloat("_Snow", actualValue);
                    }
                }

                yield return new WaitForSeconds(0.01f);
            }
        }
    }

    public void SetAurore(bool b)
    {
        aurore.SetActive(b);
    }

}
