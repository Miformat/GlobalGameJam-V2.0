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

    // Use this for initialization
    void Start () {
        currentWeather = Weather.CLEAR;
        day = true;

        skybox = RenderSettings.skybox;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SetDay(!day);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            SwitchWeather(Weather.RAIN);
        }
    }

    public void SwitchWeather(Weather w)
    {
        currentWeather = w;
    }

    public void SetDay(bool b)
    {
        day = b;
        skybox.SetFloat("_DayToNight",1f);
    }

    /*IEnumerator ChangeSkyboxValue(string paramName, float value)
    {
        float actualValue = skybox.GetFloat(paramName);
        while (actualValue>value ? skybox.GetFloat(paramName) > value : skybox.GetFloat(paramName) < value)
        {

        }
    }*/

}
