using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickable_big_shrub : MonoBehaviour
{

    void Start() {
        Time.timeScale = 1;
    }
    
    public bool big_shrub_clicked = false;
    void OnMouseDown()
    {
        big_shrub_clicked = true;
        Debug.Log("worked");
    }
}