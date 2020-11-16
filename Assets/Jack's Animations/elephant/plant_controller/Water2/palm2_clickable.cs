using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palm2_clickable : MonoBehaviour
{
    void Start() {
        Time.timeScale = 1;
    }
    
    public bool palm_clicked = false;
    void OnMouseDown()
    {
        palm_clicked = true;
    }
}