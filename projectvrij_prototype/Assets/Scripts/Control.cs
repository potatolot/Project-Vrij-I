using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Control : MonoBehaviour
{
    Ray ray;
    public RaycastHit hit;

    GameObject PlayerObject;
    GameObject ExaminableObj;
    GameObject TeleportObj;

    FridgeDoor fridged;
    TeleportIW teleport;
    ExamineSystem examinesys;

    float minDistanceToObject = 10;

    // Start is called before the first frame update
    void Start()
    {
        //game objects 
        PlayerObject = GameObject.Find("Player");
        
        //tags
        ExaminableObj = GameObject.FindWithTag("examinable");
        TeleportObj = GameObject.FindWithTag("teleportable");
        
        //scripts
        teleport = GameObject.Find("TeleportTEST").GetComponent<TeleportIW>();
        examinesys = GameObject.Find("ExamineCanvas").GetComponent<ExamineSystem>();
        fridged = GameObject.Find("FridgeDoor2").GetComponent<FridgeDoor>();

    }

    // Update is called once per frame
    void Update()
    {
        Ray();
        DebugRay();
        ExamineObj();
        Teleport();
        openFridgeDoor();

     
    }

    //all the lovely little functions I vomited out ---------------------------------------------------------------------------------

    //shows the examine box & text, this probably is really broken
    void ExamineObj()
    {
        
        float distance = Vector3.Distance(ExaminableObj.transform.position, PlayerObject.transform.position);
        //showing the text doesn't work?
        if (distance < minDistanceToObject && hit.collider.tag == "examinable" && Input.GetKeyDown(KeyCode.E))
        {
            examinesys.showExamine();
        }
    }

    //be turning on the ray that shoots out of the mouse, I could've just put this in update but lol idk
    void Ray()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    }
     //shows what's being hit with the mouse
    void DebugRay()
    { 
        if (Physics.Raycast(ray, out hit)) //display tag that's being hovered over on 
        {
            Debug.Log(hit.collider.tag);
        }

    }
    //teleports you to Inner World, this probably is really broken
    void Teleport()
    {
        float distance = Vector3.Distance(TeleportObj.transform.position, PlayerObject.transform.position);
        //teleport to inner world
        if (distance < minDistanceToObject && hit.collider.tag == "teleportable" && Input.GetKeyDown(KeyCode.E))
        {
            teleport.GoToIW();
        }
    }

    //open fridge
    void openFridgeDoor()
    {
        float distance = Vector3.Distance(TeleportObj.transform.position, PlayerObject.transform.position);
        //open up fridge door 
        if (hit.collider.tag == "fribg" && Input.GetKeyDown(KeyCode.E))
        {
            fridged.openUp();
            
        }
    }

}
