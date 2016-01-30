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

    // Use this for initialization
    void Start () {
        currentWeather = Weather.CLEAR;
        day = true;
    }

    public void SwitchWeather(Weather w)
    {
        currentWeather = w;
    }

    public void SetDay(bool b)
    {
        day = b;
    }

}
