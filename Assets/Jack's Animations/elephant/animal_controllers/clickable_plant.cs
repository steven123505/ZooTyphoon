using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickable_plant : MonoBehaviour
{

    void Start() {
        Time.timeScale = 1;
    }
    
    public bool plant_clicked = false;
    void OnMouseDown()
    {
        plant_clicked = true;
    }
}