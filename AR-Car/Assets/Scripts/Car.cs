using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float acceleration;
    public float maxSpeed;
    public float turnSpeed;
    private float curSpeed;

    public bool doAccelerate;

    private Rigidbody rig;

    public static Car instance;
    private void Awake()
    {
        instance = this;
        rig = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        /*
        if (Input.GetKey(KeyCode.Space))
            doAccelerate = true;
        else
            doAccelerate = false;

        if (Input.GetKey(KeyCode.LeftArrow))
            Turn(-1);
        else if(Input.GetKey(KeyCode.RightArrow))
            Turn(1);
        */

        if (doAccelerate)
        {
            curSpeed = Mathf.Clamp(curSpeed + (Time.deltaTime * acceleration), 0.0f, maxSpeed);
        }
        else
        {
            curSpeed = Mathf.Clamp(curSpeed - (Time.deltaTime * acceleration), 0.0f, maxSpeed);
        }

        rig.velocity = transform.forward * curSpeed;
    }

    public void Turn(float rate)
    {
        transform.Rotate(Vector3.up, rate * turnSpeed * Time.deltaTime);
    }
}
