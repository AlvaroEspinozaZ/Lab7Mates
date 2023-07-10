using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRUVelocityController : MonoBehaviour
{
    [SerializeField] Rigidbody rgb;
    [SerializeField] Vector3 acelerate;   
    [SerializeField] Vector3 v0;
    [SerializeField] Vector3 vf; 
    [SerializeField] float time;


    private void Start()
    {
        vf = ((v0 * time) + ((acelerate * Mathf.Pow(time, 2)) / 2));
        rgb.velocity = vf;
    }
}
