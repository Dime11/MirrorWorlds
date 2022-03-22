using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPortal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
       if (other.name == "Portal_1")
        {
            GameObject.Find ("OVRCameraRig").transform.position = new Vector3(3,transform.position.y-transform.position.y,-200);
        }
        else if (other.name == "Portal_2")
        {
            GameObject.Find ("OVRCameraRig").transform.position = new Vector3(3,transform.position.y-transform.position.y,0);
        }
        
    }
}
