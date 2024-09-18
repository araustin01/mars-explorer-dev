using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody Rigid;
    public WheelCollider FRW, FLW, RRW, RLW;
    public float DriveSpeed, SteerSpeed;

    float horizontalI, verticalI;

    // Start is called before the first frame update
    void Start()
    {
        horizontalI = Input.GetAxis("Horizontal");
        verticalI = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void Update()
    {
        horizontalI = Input.GetAxis("Horizontal");
        verticalI = Input.GetAxis("Vertical");

        float motor = verticalI * DriveSpeed;
        FRW.motorTorque = motor;
        FLW.motorTorque = motor;
        RRW.motorTorque = motor;
        RLW.motorTorque = motor;
        
        FLW.steerAngle = SteerSpeed * horizontalI;
        FRW.steerAngle = SteerSpeed * horizontalI;
    }
}
