using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEnable : MonoBehaviour
{
   public EmilyDoor Door;
   public Dialogue2 dialogue; 
    // Start is called before the first frame update
    void Start()
    {
        Door = GameObject.Find("Door").GetComponent<EmilyDoor>();
        dialogue = GameObject.Find("EmilyDoor").GetComponent<Dialogue2>();
    }

    private void Awake()
    {
        Door.enabled = false;
        
    }
 

    //private void OnMouseOver()
    //{
    //    if(Input.GetKeyDown(KeyCode.E) && Door.enabled == false)
    //    {
    //        StartCoroutine(dialogue.Type());
    //    }
    //}


}
