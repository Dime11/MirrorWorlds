using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRotation2 : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = target.transform.rotation;
        //transform.rotation = new Vector3(target.transform.rotation.x *0.1f, target.transform.rotation.y *0.1f, target.transform.rotation.z *0.1f);
    }
}
