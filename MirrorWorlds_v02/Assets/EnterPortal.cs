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

    void OnTriggerEnter(Collider Collider)
    {
       if (transform.position.y > -100)
        {
            GameObject.Find ("OVRCameraRig").transform.position = new Vector3(3,transform.position.y,-200);
        }
        else if (transform.position.y < -100)
        {
            GameObject.Find ("OVRCameraRig").transform.position = new Vector3(3,transform.position.y,0);
        }
        
    }
}
