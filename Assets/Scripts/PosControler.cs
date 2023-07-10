using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosControler : MonoBehaviour
{
    public int id;
    public int time;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Guar")
        {
            other.GetComponent<GuarController>().id = id + 1;
        }
    }
}
