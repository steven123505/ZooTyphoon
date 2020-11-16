using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elephant_movement : MonoBehaviour
{
    //**********General*************//
    public GameObject[] waypoints;
    public float speed;
    public float rotationSpeed;
    public int index = 0;
    public bool[] watered;
    bool lockout = false;
    public int isMoist;
    //**********General*************//

    //*********Walking Around*******//
    float WPRadius = 1.0F;
    //*********Walking Around*******//


    //*********Getting Water********//
    float WaterGettingRadius = 5.0F;
    bool HasWater = false;
    //*********Getting Water********//


    //**********Palm Trees*************//
    float PalmWaterRadius = 9.75F;

    public int palm0_selected = 0;
    public int palm1_selected = 0;
    public int palm2_selected = 0;
    public int palm3_selected = 0;
    public int palm4_selected = 0;
    public int palm5_selected = 0;
    
    public bool palm0_clicked = false;
    public bool palm1_clicked = false;
    public bool palm2_clicked = false;
    public bool palm3_clicked = false;
    public bool palm4_clicked = false;
    public bool palm5_clicked = false;

    bool lock_walking = false;
    //**********Palm Trees*************//

    //**********Animation Controls*****//
    public Animator anim;
    //**********Animation Controls*****//


    
    void Start() {
        Time.timeScale = 1;
        //gameObject.tag = "elephant_ani";
        isMoist = PlayerPrefs.GetInt("isMoist");
        anim = GetComponent<Animator>();
        if(isMoist == 2)
        {
            anim.SetBool("has_water", true);
        }
        palm0_selected = PlayerPrefs.GetInt("Tree0");
        palm1_selected = PlayerPrefs.GetInt("Tree1");
        palm2_selected = PlayerPrefs.GetInt("Tree2");
        palm3_selected = PlayerPrefs.GetInt("Tree3");
        palm4_selected = PlayerPrefs.GetInt("Tree4");
        palm5_selected = PlayerPrefs.GetInt("Tree5");
    }

    void Update(){
        isMoist = PlayerPrefs.GetInt("isMoist");

        //*********Getting Water********//
        if(isMoist == 1)
        {
            index = 15;
            if (Vector3.Distance(waypoints[index].transform.position, transform.position) > WaterGettingRadius)
            {
                transform.position = Vector3.MoveTowards(transform.position, waypoints[index].transform.position, Time.deltaTime * speed);
                float rotationStep = rotationSpeed * Time.deltaTime;
                Vector3 directionToTarget = waypoints[index].transform.position - transform.position;
                Quaternion rotationToTarget = Quaternion.LookRotation(directionToTarget);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotationToTarget, rotationStep);
            }
            else
            {
                anim.SetBool("has_water", false);
                anim.SetBool("in_lake_range", true);
                index = Random.Range(0,4);
            }
        }
        //*********Getting Water********//

        //**********Palm Trees*************//
        if(isMoist == 2)
        {
            palm0_clicked = GameObject.Find("/palm_water0/palm_base/palm_base0").GetComponent<palm0_clickable>().palm_clicked;
            palm1_clicked = GameObject.Find("/palm_water1/palm_base/palm_base1").GetComponent<palm1_clickable>().palm_clicked;
            palm2_clicked = GameObject.Find("/palm_water2/palm_base/palm_base2").GetComponent<palm2_clickable>().palm_clicked;
            palm3_clicked = GameObject.Find("/palm_water3/palm_base/palm_base3").GetComponent<palm3_clickable>().palm_clicked;
            palm4_clicked = GameObject.Find("/palm_water4/palm_base/palm_base4").GetComponent<palm4_clickable>().palm_clicked;
            palm5_clicked = GameObject.Find("/palm_water5/palm_base/palm_base5").GetComponent<palm5_clickable>().palm_clicked;
            
            Debug.Log(palm2_clicked);

            if (palm0_clicked == true && lockout == false && palm0_selected == 0){
                index = 4; // palms 0 and 3 are switched
                anim.SetInteger("activation_number", 0);
                lockout = true;
                PlayerPrefs.SetInt("Tree0", 1);
                palm1_selected = 1;
            }
            else if (palm1_clicked == true && lockout == false && palm1_selected == 0){
                index = 5; // 5th element in waypoint vector
                anim.SetInteger("activation_number", 1);
                lockout = true;
                PlayerPrefs.SetInt("Tree1", 1);
                palm1_selected = 1;
            }
            else if (palm2_clicked == true && lockout == false && palm2_selected == 0){
                index = 6;
                anim.SetInteger("activation_number", 2);
                lockout = true;
                Debug.Log("palm2");
                PlayerPrefs.SetInt("Tree2", 1);
                palm2_selected = 1;
            }
            else if (palm3_clicked == true && lockout == false && palm3_selected == 0){
                index = 7;
                anim.SetInteger("activation_number", 3);
                lockout = true;
                Debug.Log("palm3");
                PlayerPrefs.SetInt("Tree3", 1);
                palm3_selected = 1;
            }
            else if (palm4_clicked == true && lockout == false && palm4_selected == 0){
                index = 8;
                anim.SetInteger("activation_number", 4);
                lockout = true;
                Debug.Log("palm4");
                PlayerPrefs.SetInt("Tree4", 1);
                palm4_selected = 1;
            }
            else if (palm5_clicked == true && lockout == false && palm5_selected == 0){
                index = 9;
                anim.SetInteger("activation_number", 5);
                lockout = true;
                Debug.Log("palm5");
                PlayerPrefs.SetInt("Tree5", 1);
                palm5_selected = 1;
            }

        
            if (Vector3.Distance(waypoints[index].transform.position, transform.position) > PalmWaterRadius && index > 3){
                transform.position = Vector3.MoveTowards(transform.position, waypoints[index].transform.position, Time.deltaTime * speed);
                float rotationStep = rotationSpeed * Time.deltaTime;
                Vector3 directionToTarget = waypoints[index].transform.position - transform.position;
                Quaternion rotationToTarget = Quaternion.LookRotation(directionToTarget);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotationToTarget, rotationStep);
            }
            else if(index > 3 && index != 15)
            {
                anim.SetBool("in_range_of_plant", true);
                index = Random.Range(0,4);
                lock_walking = true;
            }

        }
        //**********Palm Trees*************//


        //*********Walking Around*******//
        if((isMoist == 0 || isMoist == 2) && (index < 4 || index == 15) && (isMoist == 0 || lock_walking == false))
        {
            lockout = false;
            lock_walking = false;
            if (Vector3.Distance(waypoints[index].transform.position, transform.position) < WPRadius)
            {
                int temp = index;
                index = Random.Range(0,4);
                while(temp == index)
                {
                    index = Random.Range(0,4);
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, waypoints[index].transform.position, Time.deltaTime * speed);
            float rotationStep = rotationSpeed * Time.deltaTime;
            Vector3 directionToTarget = waypoints[index].transform.position - transform.position;
            Quaternion rotationToTarget = Quaternion.LookRotation(directionToTarget);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotationToTarget, rotationStep);
        }
        //*********Walking Around*******//
        
    }
}
