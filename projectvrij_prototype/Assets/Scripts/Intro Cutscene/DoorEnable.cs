using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEnable : MonoBehaviour
{
   public EmilyDoor Door;
    // Start is called before the first frame update
    void Start()
    {
        Door = GameObject.Find("Door").GetComponent<EmilyDoor>();
    }

    private void Awake()
    {
        Door.enabled = false;
    }
}
