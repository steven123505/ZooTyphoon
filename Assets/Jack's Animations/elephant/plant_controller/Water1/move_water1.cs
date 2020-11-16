using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_water1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = new Vector3(.0f, -.5f, .0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move()
    {
        StartCoroutine(Move_helper());
    }

    public IEnumerator Move_helper()
    {
        yield return new WaitForSeconds(2.9f);
        transform.localPosition = new Vector3(.0f, .0f, .0f);
    }
}
