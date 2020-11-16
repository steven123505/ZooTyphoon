﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class base_move5 : MonoBehaviour
{
     public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Time.timeScale = 1;
        if(PlayerPrefs.GetInt("Tree5") == 1)
        {
            transform.localPosition = new Vector3(.0f, -.5f, .0f);
        }
    }

    public void Move()
    {
        StartCoroutine(Move_helper());
    }

    public IEnumerator Move_helper()
    {
        yield return new WaitForSeconds(9.8f);
        transform.localPosition = new Vector3(.0f, -.5f, .0f);
    }
}