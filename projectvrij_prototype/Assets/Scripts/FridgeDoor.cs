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

    public void openUp()
    {
        //how do you make it closed again 
        if (!fDoorOpen)
        {
            fdoor.transform.Rotate(0, 90, 0);
            fDoorOpen = !fDoorOpen;
            Debug.Log("i opened motherfucker");
        }
        else
        {
            
        }
        
        
    }
}
