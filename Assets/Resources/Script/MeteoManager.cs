using UnityEngine;
using System.Collections;

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

    // Use this for initialization
    void Start () {
        currentWeather = Weather.CLEAR;
        day = true;

        skybox = RenderSettings.skybox;

        skybox.SetFloat("_DayToNight", 0f);
        skybox.SetFloat("_RainToSnow", 0f);
        skybox.SetFloat("_NormalToRainSnow", 0f);

        mainLight = FindObjectOfType<Light>();
    }

    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SetDay(!day);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            SwitchWeather(Weather.RAIN);
        }
    }*/

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

        UpdateColor();
    }

    public void SetDay(bool b)
    {
        day = b;

        StartCoroutine(ChangeSkyboxValue("_DayToNight", day ? 0f : 1f));

        UpdateColor();
    }

    void UpdateColor()
    {
        switch (currentWeather)
        {
            case Weather.CLEAR:
                mainLight.color = day ? colorDay : colorNight;
                break;
            case Weather.RAIN:
                mainLight.color = day ? colorDayRain : colorNightRain;
                break;
            case Weather.SNOW:
                mainLight.color = day ? colorDaySnow : colorNightSnow;
                break;

        }
    }

    IEnumerator ChangeSkyboxValue(string paramName, float value)
    {
        float actualValue = skybox.GetFloat(paramName);
        
        if (actualValue > value)
        {
            while (skybox.GetFloat(paramName) > value)
            {
                actualValue -= 0.1f;
                skybox.SetFloat(paramName, actualValue);
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            while (skybox.GetFloat(paramName) < value)
            {
                actualValue += 0.1f;
                skybox.SetFloat(paramName, actualValue);
                yield return new WaitForSeconds(0.01f);
            }
        }
    }

}
