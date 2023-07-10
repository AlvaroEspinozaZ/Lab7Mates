using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcosadorC : MonoBehaviour
{
    public Transform player;
    public Rigidbody rgb;
    public float time;
    Vector3 vf;

    private void Start()
    {
        vf = (player.position - transform.position) / time;
        rgb.velocity = vf;
    }

    private void Update()
    {
        if (time > 0)
        {
            time =Mathf.Clamp( time - Time.deltaTime,0.1f, time+1);
        }
        Vector3 tmp = (player.position - transform.position) / (time);
        rgb.velocity +=  tmp * Time.deltaTime;
    }
}
