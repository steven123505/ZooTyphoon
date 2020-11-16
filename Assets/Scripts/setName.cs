using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Gets the name input and stores it in player prefs file.
public class setName : MonoBehaviour
{
    public InputField field;
    public void storeName()
    {
        PlayerPrefs.SetString("name", field.text);
    }
}
