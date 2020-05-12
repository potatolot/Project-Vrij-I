using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController player;

    GameObject PlayerObject;
    GameObject ExaminableObj;
    GameObject TeleportObj;

    TeleportIW teleport;
    ExamineSystem examinesys;

    Ray ray;
    RaycastHit hit;

    public float speed = 12f;
    float minDistanceToObject = 5;
    bool colliding = false;



    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        PlayerObject = GameObject.Find("Player");

        ExaminableObj = GameObject.FindWithTag("examinable");
        TeleportObj = GameObject.FindWithTag("teleportable");


        teleport = GameObject.Find("TeleportTEST").GetComponent<TeleportIW>();
        examinesys = GameObject.Find("ExamineBox").GetComponent<ExamineSystem>();

    }

    // Update is called once per frame
    void Update()
    {

        Move();
        ExamineObj();
        Teleport();
        DebugRay();


    }


    void Move()
    {
        //movement input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //walcc
        Vector3 move = transform.right * x + transform.forward * z;

        player.Move(move * speed * Time.deltaTime);
    }

    void ExamineObj()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float distance = Vector3.Distance(ExaminableObj.transform.position, PlayerObject.transform.position);
            //examine items
            if (distance < minDistanceToObject && hit.collider.tag == "examinable" && Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("beep boop imma work now");
                examinesys.showExamine();
            }
        }
    }

    void Teleport()
    {
        float distance = Vector3.Distance(TeleportObj.transform.position, PlayerObject.transform.position);
        //teleport to inner world
        if (distance < minDistanceToObject && hit.collider.tag == "teleportable" && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("nyoom");
            teleport.GoToIW();
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

   
}
    


