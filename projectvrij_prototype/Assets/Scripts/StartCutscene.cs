using EPOOutline;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCutscene : MonoBehaviour
{
    PlayerMovement pmovement;
    public DialogueTrigger dialoguetrigger;
    DialogueManager dialoguemanager;

    DialogueTrigger doorCutscene;

    States states;
    public bool DoorCutsceneTriggered = false;
    public bool DoorCutsceneDone = false;
    Outlinable outline;
    // Start is called before the first frame update
    void Start()
    {
        pmovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        dialoguemanager = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();
        states = GameObject.Find("StateObject").GetComponent<States>();
        outline = GameObject.Find("Cutscene_Door").GetComponent<Outlinable>();
        doorCutscene = GameObject.Find("Cutscene_Door").GetComponent<DialogueTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        if(dialoguemanager.isFinished && DoorCutsceneTriggered)
        {
            StartCoroutine(CloseDoor());
            dialoguemanager.isFinished = false;
            states.currentState = States.PlayerStates.Cutscene;
        }
    }

    public void CutsceneTriggered()
    {
        states.currentState = States.PlayerStates.Cutscene;

        // sound of knocking

        StartCoroutine(DoorAndDialogue());
        


    }

    IEnumerator DoorAndDialogue()
    {
        DoorCutsceneTriggered = true;
        yield return new WaitForSeconds(1);
        Quaternion targetRotation = Quaternion.Euler(0.0f, -40.0f, 0.0f);
        this.transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, 2.0f);

        dialoguetrigger.TriggerDialogue();
        
    }



    IEnumerator CloseDoor()
    {
       
        yield return new WaitForSeconds(1);
        Quaternion targetRotation = Quaternion.Euler(0.0f, -90.0f, 0.0f);
        this.transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, 2.0f);
        
        Destroy(GameObject.Find("TriggerCutscene"));
        states.currentState = States.PlayerStates.Interact;
        outline.enabled = false;
        DoorCutsceneDone = true;
        //show what task to do!
        //askedleyla
    }
}
