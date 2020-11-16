using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script saves what has happened in the wolf exhibit
public class wolfSaver : MonoBehaviour
{

    public GameObject meat_steak;
    public GameObject bridge;
    public GameObject bridge1;
    public GameObject ball;

    // Update is called once per frame
    void Update()
    {

        // For each object that the player can activate, set them as active iff the global var is active
        meat_steak.SetActive((PlayerPrefs.GetInt("steak") == 1) ? true : false);

        bridge.SetActive((PlayerPrefs.GetInt("bridge") == 1) ? true : false);
        bridge1.SetActive((PlayerPrefs.GetInt("bridge") == 1) ? true : false);

        ball.SetActive((PlayerPrefs.GetInt("ball") == 1) ? true : false);

    }
}
