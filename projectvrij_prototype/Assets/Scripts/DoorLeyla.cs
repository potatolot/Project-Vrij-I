using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLeyla : MonoBehaviour
{
    GameObject leyladoor;
    public DialogueTrigger dialoguetrigger;
    DialogueManager dialoguemanager;
    // Start is called before the first frame update
    void Start()
    {
        leyladoor = GameObject.Find("Dooritself");
        dialoguemanager = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            dialoguetrigger.TriggerDialogue();
            //open door 
            Quaternion targetRotation = Quaternion.Euler(0.0f, 0.0f, -90f);
            leyladoor.transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, 2.0f);
        }
    }
}
