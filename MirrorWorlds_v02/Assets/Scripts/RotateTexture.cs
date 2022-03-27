using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTexture : MonoBehaviour
{
    public float scrollX = 0.5f;
    public float scrollY = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float OffsetX = Time.time * scrollX;
        float OffsetY = scrollY;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (OffsetX, OffsetY);
    }
}
