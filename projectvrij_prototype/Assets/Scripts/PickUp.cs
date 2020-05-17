using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    public Transform dest;

    bool pickedup = false;
    bool hover = false;

    private void Start()
    {

    }

    private void Update()
    {
        PickUpItem();
    }

    void OnMouseOver()
    {
        hover = true;
        Debug.Log("hovered:" + hover);
    }

    private void OnMouseExit()
    {
        hover = false;
        Debug.Log("hovered:" + hover);
    }

    void PickUpItem()
    {
        if (Input.GetKeyDown(KeyCode.E))
        { 
            if (!pickedup && hover)
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

        

}
