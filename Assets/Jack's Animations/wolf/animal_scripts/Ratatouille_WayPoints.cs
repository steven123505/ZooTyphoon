using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ratatouille_WayPoints : MonoBehaviour
{
    public GameObject[] waypoints;
    public GameObject[] log;
    int current = 0;
    float rotSpeed;
    public float speed;
    float WPradius = 1;
    public float rotationSpeed;
    public bool log_clicked = false;

    void Start() {
        Time.timeScale = 1;
    }

    void OnMouseDown()
    {
        log_clicked = true;
        Debug.Log("worked");
    }

    // Update is called once per frame
    void Update()
    {
        log_clicked = GameObject.Find("log").GetComponent<clickable_log>().log_clicked;
        if(log_clicked == true)
        {
            if(Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
            {
                current++;
                if (current >= waypoints.Length)
                {
                    current = 0;
                    GameObject.Find("log").GetComponent<clickable_log>().log_clicked = false;
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
