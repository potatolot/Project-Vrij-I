using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCutscene : MonoBehaviour
{
    PlayerMovement pmovement;
    public DialogueTrigger dialoguetrigger;
    DialogueManager dialoguemanager;

    States states;

    // Start is called before the first frame update
    void Start()
    {
        pmovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        dialoguemanager = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();
        states = GameObject.Find("StateObject").GetComponent<States>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dialoguemanager.dialogueEnded)
        {
            StartCoroutine(CloseDoor());
           
        
            //dialoguemanager.dialogueEnded = false;
        }
    }

    public void CutsceneTriggered()
    {
        states.currentState = States.PlayerStates.DialogueState;
        // sound of knocking

        StartCoroutine(DoorAndDialogue());
        


    }

    IEnumerator DoorAndDialogue()
    {
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
        //show what task to do!
    }
}
