using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_WayPoints : MonoBehaviour
{
    public GameObject[] waypoints;
    public GameObject[] plant;
    int current = 0;
    float rotSpeed;
    public float speed;
    float WPradius = 1;
    public float rotationSpeed;
    public bool plant_clicked = false;

    void Start() {
        Time.timeScale = 1;
    }

    void OnMouseDown()
    {
        plant_clicked = true;
    }

    // Update is called once per frame
    void Update()
    {
        plant_clicked = GameObject.Find("plant").GetComponent<clickable_plant>().plant_clicked;
        if(plant_clicked == true)
        {
            if(Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
            {
                current++;
                if (current >= waypoints.Length)
                {
                    current = 0;
                    GameObject.Find("plant").GetComponent<clickable_plant>().plant_clicked = false;
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
