using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickable_pb1 : MonoBehaviour
{
    void Start() {
        Time.timeScale = 1;
    }

    public bool pb_one = false;
    void OnMouseDown()
    {
        pb_one = true;
    }
}
