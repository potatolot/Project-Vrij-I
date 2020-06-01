﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueLaylaCutscene : MonoBehaviour
{
    GameObject door;
    GameObject triggerc;
    Dialogue2 dialogue2;
    States states;

    public bool laylaDialogue = false;
    public bool CutsceneDone = false;
    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("Cutscene_Door");
        triggerc = GameObject.Find("TriggerCutscene");
        dialogue2 = GameObject.Find("Cutscene_Door").GetComponent<Dialogue2>();
        states = GameObject.Find("StateObject").GetComponent<States>();
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogue2.hasFinished && laylaDialogue)
        {
            states.currentState = States.PlayerStates.Interact;
            Quaternion targetRotation = Quaternion.Euler(0.0f, -90.0f, 0.0f);
            this.transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, 2.0f);
            StopAllCoroutines();
            CutsceneDone = true;
        }
    }

    public void OpenDoor()
    {
        Quaternion targetRotation = Quaternion.Euler(0.0f, -40.0f, 0.0f);
        this.transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, 2.0f);
        
        StartCoroutine(Dialogue());
    }

    IEnumerator Dialogue()
    {
        yield return new WaitForSeconds(1);
        laylaDialogue = true;
        StartCoroutine(dialogue2.Type());
    }
}