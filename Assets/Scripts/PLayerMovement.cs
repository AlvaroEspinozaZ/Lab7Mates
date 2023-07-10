using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMovement : MonoBehaviour
{
    public Rigidbody rgb;
    float x,y;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        rgb.velocity = new Vector3(x * 5, rgb.velocity.y, y * 5) ;
    }
}
