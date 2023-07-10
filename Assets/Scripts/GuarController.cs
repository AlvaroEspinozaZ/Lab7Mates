using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuarController : MonoBehaviour
{
    public PosControler[] listaPos;
    public Rigidbody rgb;
    public int id=3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (id == 4)
        {
            id = 0;
        }
        rgb.velocity = (listaPos[id].gameObject.transform.position - transform.position) / listaPos[id].time;
    }
}
