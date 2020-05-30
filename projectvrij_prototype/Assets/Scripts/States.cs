using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class States : MonoBehaviour
{
    public enum PlayerStates
    {
        DialogueState,
        Cutscene,
        Interact
    }

    public bool Epressed = false;
    public PlayerStates currentState;


    DialogueManager dialoguemanager;
    PlayerMovement pmovement;

    // Start is called before the first frame update
    void Start()
    {
        dialoguemanager = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();
        pmovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case PlayerStates.DialogueState:
                Debug.Log("In dialogue state");
                pmovement.isActive = false;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    dialoguemanager.DisplayNextSentence();
                }
                break;

            case PlayerStates.Cutscene:
                pmovement.isActive = false;
                Debug.Log("wee cutscene");
                break;

            case PlayerStates.Interact:
                pmovement.isActive = true;
                
                break;
        }
    }
}
