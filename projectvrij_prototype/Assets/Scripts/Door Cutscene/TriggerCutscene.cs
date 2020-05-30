using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCutscene : MonoBehaviour
{
    StartCutscene cutscene;
    DialogueManager dialoguemanager;
    public DialogueTrigger dialoguetrigger;
    States states;

    bool triggerEntered = true;

    public bool hasFinished = false;
    private void Start()
    {
        cutscene = GameObject.Find("Cutscene_Door").GetComponent<StartCutscene>();
        dialoguemanager = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();
        dialoguetrigger = GameObject.Find("TriggerCutscene").GetComponent<DialogueTrigger>();
        states = GameObject.Find("StateObject").GetComponent<States>();
    }

    private void Update()
    {
        if(dialoguemanager.isFinished && triggerEntered)
        {
            cutscene.CutsceneTriggered();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(DialogueEmilyStart());
        states.currentState = States.PlayerStates.Cutscene;
        dialoguemanager.trigger = this.gameObject;
        triggerEntered = true;
    }

    IEnumerator DialogueEmilyStart()
    {
        //knock sound
        yield return new WaitForSeconds(2);
        dialoguetrigger.TriggerDialogue();

    }
}
