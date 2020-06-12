using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PickUp: MonoBehaviour
{
    public Transform dest;
    public Rigidbody rb;
    States states;

    bool pickedup = false;
    bool hover = false;

    GameObject PlayerObject;

    float minDistanceToObject = 8;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        states = GameObject.Find("StateObject").GetComponent<States>();
        PlayerObject = GameObject.Find("Player");
    }

    private void Update()
    {
        PickUpItem();
        
    }

    void OnMouseOver()
    {
        hover = true;
     
        
    }

    private void OnMouseExit()
    {
        hover = false;
      
    }

    void PickUpItem()
    {
        float distance = Vector3.Distance(this.transform.position, PlayerObject.transform.position);

        if (Input.GetKeyDown(KeyCode.E) && distance < minDistanceToObject)
        {
            if (!pickedup && hover)
            {
                rb.useGravity = false; //turn off gravity
                //rb.freezeRotation = true;
                this.transform.position = dest.position;
                this.transform.parent = GameObject.Find("Destination").transform;
                //rb.isKinematic = true;

                pickedup = true;
                //Debug.Log("pickedup=" + pickedup);
            }
        else
        {
            this.transform.parent = null;
            rb.useGravity = true;

            //rb.freezeRotation = false;
            pickedup = false;

            //rb.isKinematic = false;

            Debug.Log("pickedup=" + pickedup);
        }
            if (!pickedup)
            {
                rb.useGravity = true;
            }
        }

    }

        

}
