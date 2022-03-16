using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRotation : MonoBehaviour
{
    public float rotationFactorX = 0.5f;
    public float rotationFactorY = 0.5f;
    public float rotationFactorZ = 0.5f;
    public Transform target;
    
    float currentAngleX;
    float currentAngleY;
    float currentAngleZ;

    void Update()
    {
        SetNegativeAngles (out currentAngleX, target.localEulerAngles.x);
        SetNegativeAngles (out currentAngleY, target.localEulerAngles.y);
        SetNegativeAngles (out currentAngleZ, target.localEulerAngles.z);

        transform.localEulerAngles = new Vector3(currentAngleX * rotationFactorX, currentAngleY * rotationFactorY, currentAngleZ * rotationFactorZ);
    }

    float SetNegativeAngles(out float angle, float refFloat)
    { 
        angle = refFloat;
        angle = (angle > 180) ? angle - 360 : angle;
        return angle;
    }
}
