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

    public Color colorNight = new Color(0.4f, 0.22f, 0.56f);
    public Color colorNightRain = new Color(1f, 0.86f, 0.82f);
    public Color colorNightSnow = new Color(1f, 0.86f, 0.82f);

    GameObject rain;
    GameObject snow;

    TrackManager tM;

    // Use this for initialization
    void Start () {
        currentWeather = Weather.CLEAR;
        day = true;

        skybox = RenderSettings.skybox;

        skybox.SetFloat("_DayToNight", 0f);
        skybox.SetFloat("_RainToSnow", 0f);
        skybox.SetFloat("_NormalToRainSnow", 0f);

        mainLight = FindObjectOfType<Light>();

        foreach (Material m in materials)
        {
            m.SetFloat("_Snow", 0f);
        }

        rain = GameObject.Find("PS_Rain");
        snow = GameObject.Find("PS_Snowflakes");

        rain.SetActive(false);
        snow.SetActive(false);

        tM = FindObjectOfType<TrackManager>();
    }

    public void SwitchWeather(Weather w)
    {
        Weather oldWeather = currentWeather;
        currentWeather = w;
        
        switch (currentWeather)
        {
            case Weather.CLEAR:
                StartCoroutine(ChangeSkyboxValue("_NormalToRainSnow", 0f));
                StartCoroutine(ChangeSkyboxValue("_RainToSnow", 0f));
                break;
            case Weather.RAIN:
                StartCoroutine(ChangeSkyboxValue("_NormalToRainSnow", 1f));
                StartCoroutine(ChangeSkyboxValue("_RainToSnow", 0f));
                break;
            case Weather.SNOW:
                StartCoroutine(ChangeSkyboxValue("_NormalToRainSnow", 1f));
                StartCoroutine(ChangeSkyboxValue("_RainToSnow", 1f));
                break;
        }

        tM.meteo = currentWeather;

        UpdateColor();
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
                rain.SetActive(false);
                snow.SetActive(false);
                mainLight.color = day ? colorDay : colorNight;
                break;
            case Weather.RAIN:
                rain.SetActive(true);
                snow.SetActive(false);
                mainLight.color = day ? colorDayRain : colorNightRain;
                break;
            case Weather.SNOW:
                rain.SetActive(false);
                snow.SetActive(true);
                mainLight.color = day ? colorDaySnow : colorNightSnow;
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

}
