using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deer_WayPoints : MonoBehaviour
{
    public GameObject[] waypoints;
    public GameObject[] big_shrub;
    int current = 0;
    float rotSpeed;
    public float speed;
    float WPradius = 1;
    public float rotationSpeed;
    public bool big_shrub_clicked = false;

    void Start() {
        Time.timeScale = 1;
    }

    void OnMouseDown()
    {
        big_shrub_clicked = true;
        Debug.Log("worked");
    }

    // Update is called once per frame
    void Update()
    {
        big_shrub_clicked = GameObject.Find("big_shrub").GetComponent<clickable_big_shrub>().big_shrub_clicked;
        if(big_shrub_clicked == true)
        {
            if(Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
            {
                current++;
                if (current >= waypoints.Length)
                {
                    current = 0;
                    GameObject.Find("big_shrub").GetComponent<clickable_big_shrub>().big_shrub_clicked = false;
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
            float rotationStep = rotationSpeed * Time.deltaTime;
            Vector3 directionToTarget = waypoints[current].transform.position - transform.position;
            Quaternion rotationToTarget = Quaternion.LookRotation(directionToTarget);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotationToTarget, rotationStep);
        }
    }

}
