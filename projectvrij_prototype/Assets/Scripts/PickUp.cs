using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform dest;
    Control control;

    private void Start()
    {
        control = GameObject.Find("Control").GetComponent<Control>();
    }
    void OnMouseOver() 
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Rigidbody>().useGravity = false; //turn off gravity
            this.transform.position = dest.position;
            this.transform.parent = GameObject.Find("Destination").transform;
        }
    }

    void OnMouseExit() //this doesn't work but I'm gonna fix it later
    { 

       this.transform.parent = null;
       GetComponent<Rigidbody>().useGravity = true;

    }

}
