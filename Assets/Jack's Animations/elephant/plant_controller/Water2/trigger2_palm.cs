using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger2_palm : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Time.timeScale = 1;
        if(PlayerPrefs.GetInt("Tree2") == 1)
        {
            anim.SetBool("move", true);
        }
    }

    public void Move()
    {
        StartCoroutine(Move_helper());
    }

    public IEnumerator Move_helper()
    {
        yield return new WaitForSeconds(11.0f);
        anim.SetBool("move", true);
    }
}
