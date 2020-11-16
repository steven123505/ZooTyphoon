using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Script to close a tutorial text box
// Option to have buttons/no buttons
//      Buttons: You have two buttons (go back to map and breathe) that begin as not interactable
//               Once the text box is closed, set them as interactable
//      No Buttons: No buttons (generally used in the breathe screens)

public class CloseTextBox : MonoBehaviour
{
    public Image textBox;
    public GameObject panel;
    public Button button1;
    public Button button2;

    public void closeBox()
    {
        textBox.gameObject.SetActive(false);
        button1.interactable = true;
        button2.interactable = true;
    }

    public void closeBoxNoButtons()
    {
        textBox.gameObject.SetActive(false);
    }


    public void closePanel()
    {
        panel.SetActive(false);
        button1.interactable = true;
        button2.interactable = true;
    }
}
