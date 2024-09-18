using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    public WheelCollider WCollider;
    public Transform WheelMesh;
    public bool WheelTurn;

    // Update is called once per frame
    void Update()
    {
        if (WheelTurn)
            WheelMesh.localEulerAngles = new Vector3(WheelMesh.localEulerAngles.x, WCollider.steerAngle - WheelMesh.localEulerAngles.z, WheelMesh.localEulerAngles.z);
            
        WheelMesh.Rotate(WCollider.rpm / 60 * 360 * Time.deltaTime, 0, 0);
    }
}
