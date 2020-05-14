using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    GameObject PlayerObject;
    GameObject ExaminableObj;
    GameObject TeleportObj;

    TeleportIW teleport;
    ExamineSystem examinesys;

    float minDistanceToObject = 10;

    // Start is called before the first frame update
    void Start()
    {
        PlayerObject = GameObject.Find("Player");

        ExaminableObj = GameObject.FindWithTag("examinable");
        TeleportObj = GameObject.FindWithTag("teleportable");


        teleport = GameObject.Find("TeleportTEST").GetComponent<TeleportIW>();
        examinesys = GameObject.Find("ExamineCanvas").GetComponent<ExamineSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        DebugRay();
        ExamineObj();
        Teleport();
    }
    void ExamineObj()
    {
        float distance = Vector3.Distance(ExaminableObj.transform.position, PlayerObject.transform.position);
        //examine items
        if (distance < minDistanceToObject && hit.collider.tag == "examinable" && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("beep boop imma work now");
            examinesys.showExamine();
        }
    }

    
    void DebugRay()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit)) //display tag that's being hovered over on 
        {
            Debug.Log(hit.collider.tag);
        }

    }

    void Teleport()
    {
        float distance = Vector3.Distance(TeleportObj.transform.position, PlayerObject.transform.position);
        //teleport to inner world
        if (distance < minDistanceToObject && hit.collider.tag == "teleportable" && Input.GetKeyDown(KeyCode.E))
        {
            teleport.GoToIW();
        }
    }
}
