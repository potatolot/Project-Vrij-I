using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeDoor : MonoBehaviour
{
    GameObject fdoor;

    bool fDoorOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        fdoor = GameObject.Find("FridgeDoor2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.E))
        { 
            openUp();
        }
    }
    public void openUp()
    {
        //how do you make it closed again 
        if (!fDoorOpen)
        {
            Quaternion targetRotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
            fdoor.transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, 2.0f);
            fDoorOpen = true;
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            fdoor.transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, 2.0f);
            fDoorOpen = false;
        }


    }
}
