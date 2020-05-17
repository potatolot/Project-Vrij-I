using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform dest;
    
    bool pickedup = false;

    private void Start()
    {
       
    }

    private void Update()
    {
        Debug.Log("pickedup=" + pickedup);
       
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PickUpItem();
        }
    }

    void PickUpItem()
    {
        if (!pickedup)
        {
            GetComponent<Rigidbody>().useGravity = false; //turn off gravity
            this.transform.position = dest.position;
            this.transform.parent = GameObject.Find("Destination").transform;
            pickedup = true;
        }
        else
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            pickedup = false;
        }
            
    }

        

}
