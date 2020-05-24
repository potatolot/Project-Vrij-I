using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeDoor1 : MonoBehaviour
{
    GameObject PlayerObject;

    float minDistanceToObject = 10;

    bool fDoorOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        PlayerObject = GameObject.Find("Player");
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
        float distance = Vector3.Distance(this.transform.position, PlayerObject.transform.position);

        if (!fDoorOpen &&  distance < minDistanceToObject)
        {
            Quaternion targetRotation = Quaternion.Euler(0.0f, -90.0f, 0.0f);
            this.transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, 2.0f);
            fDoorOpen = true;
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            this.transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, 2.0f);
            fDoorOpen = false;
        }


    }
}
