using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IOS_controls : MonoBehaviour
{

    // Start is called before the first frame update
    public Joystick joystick;
    public Joystick joystick2;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joystick.Horizontal * 100f,
                                        rigidbody.velocity.y,
                                        joystick.Vertical * 100f);

        Debug.Log(rigidbody.velocity);

    }
}
