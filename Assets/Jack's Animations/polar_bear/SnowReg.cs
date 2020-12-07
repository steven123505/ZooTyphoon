using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowReg : MonoBehaviour
{
    ParticleSystem ps;
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        var emission = ps.emission;
        float temp_in = PlayerPrefs.GetFloat("PolarTemp");
        if(temp_in >= .9)
        {
            ps.Play();
            emission.rate = 10f;
        }
        else if(temp_in >= .8)
        {
            ps.Play();
            emission.rate = 100f;
        }
        else if(temp_in >= .7)
        {
            
        }
        else if(temp_in >= .6)
        {
            
        }
        else if(temp_in >= .5)
        {
           
        }
        else if(temp_in >= .4)
        {
           
        }
        else if(temp_in >= .3)
        {
            
        }
        else if(temp_in >= .2)
        {
            
        }
        else
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        ps = GetComponent<ParticleSystem>();
        var emission = ps.emission;
        float temp_in = PlayerPrefs.GetFloat("PolarTemp");
        if(temp_in >= .9)
        {
            ps.Play();
            emission.rate = 1f;
        }
        else if(temp_in >= .8)
        {
            ps.Play();
            emission.rate = 50f;
        }
        else if(temp_in >= .7)
        {
            ps.Play();
            emission.rate = 100f;
        }
        else if(temp_in >= .6)
        {
            ps.Play();
            emission.rate = 150f;
        }
        else if(temp_in >= .5)
        {
           ps.Play();
            emission.rate = 250f;
        }
        else if(temp_in >= .4)
        {
           ps.Play();
            emission.rate = 350f;
        }
        else if(temp_in >= .3)
        {
            ps.Play();
            emission.rate = 500f;
        }
        else if(temp_in >= .2)
        {
            ps.Play();
            emission.rate = 750f;
        }
        else
        {
            ps.Play();
            emission.rate = 1000f;
        }
    }
}
