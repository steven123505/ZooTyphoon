using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickable_log : MonoBehaviour
{

    void Start() {
        Time.timeScale = 1;
    }
    
    public bool log_clicked = false;
    void OnMouseDown()
    {
        log_clicked = true;
        Debug.Log("worked");
    }
}