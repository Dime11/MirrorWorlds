using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotTowards : MonoBehaviour
{
    //values that will be set in the Inspector
     public Transform Target;
     public float RotationSpeed;

     public int fromAngle;
     public int toAngle;

     public int startAngle;
 
     //values for internal use
     private Quaternion _lookRotation;
     private Vector3 _direction;
     
     // Update is called once per frame
     void Update()
     {
        if((Target.transform.rotation.eulerAngles.y > fromAngle) && (Target.transform.rotation.eulerAngles.y < toAngle))
        {
             //find the vector pointing from our position to the target
             _direction = (Target.position - transform.position).normalized;
 
             //create the rotation we need to be in to look at the target
             _lookRotation = Quaternion.LookRotation(_direction);
 
            //rotate us over time according to speed until we are in the required rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * RotationSpeed);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(20,startAngle,0), Time.deltaTime * RotationSpeed);
        }
     }
}