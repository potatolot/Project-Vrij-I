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
            GetComponent<Rigidbody>().freezeRotation = true;
            this.transform.position = dest.position;
            this.transform.parent = GameObject.Find("Destination").transform;


            pickedup = true;
            Debug.Log("pickedup=" + pickedup);

        }
        else
        {

            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Rigidbody>().freezeRotation = false;
            pickedup = false;
            Debug.Log("pickedup=" + pickedup);
        }
            
    }

        

}
