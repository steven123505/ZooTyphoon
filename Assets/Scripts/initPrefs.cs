using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    public void newGame()
    {
        PlayerPrefs.SetFloat("PolarTemp", -1f);
        PlayerPrefs.SetInt("coinz", 0);
        PlayerPrefs.SetInt("steak", 0);
        PlayerPrefs.SetInt("bridge", 0);
        PlayerPrefs.SetInt("ball", 0);
        PlayerPrefs.SetInt("isMoist", 0);
        PlayerPrefs.SetInt("Tree0", 0);
        PlayerPrefs.SetInt("Tree1", 0);
        PlayerPrefs.SetInt("Tree2", 0);
        PlayerPrefs.SetInt("Tree3", 0);
        PlayerPrefs.SetInt("Tree4", 0);
        PlayerPrefs.SetInt("Tree5", 0);
    }

}
