using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePlate : MonoBehaviour
{
    public Dialogue_Auto dialogue;
    public States states;
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(dialogue.Type());

        states.currentState = States.PlayerStates.Cutscene;
    }
}
