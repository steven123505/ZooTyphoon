using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// This script updates the text of the avatar
// It assumes that there is a "name" and a "coinz" variable in the PlayerPrefs file
// Formats the text and puts it onto the avatar icon
public class avatarScript : MonoBehaviour
{

    public Text txt;

    void Start()
    {
        txt.text = PlayerPrefs.GetString("name") + "\n" + PlayerPrefs.GetInt("coinz") + " Coins";
    }

}
