using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// On new game, the polar temperature is set to -1 to distinguish between cold and not started
// This initializes the thermometer to the hottest if this is a new game.
public class temperatureInit : MonoBehaviour
{
    public Slider temperature;

    void Awake()
    {
        if (PlayerPrefs.GetFloat("PolarTemp") < 0f)
        {
            PlayerPrefs.SetFloat("PolarTemp", 1f);
        }
        temperature.value = PlayerPrefs.GetFloat("PolarTemp");
    }
    void Update()
    {
        
    }

}
