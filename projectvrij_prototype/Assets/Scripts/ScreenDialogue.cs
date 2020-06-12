using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenDialogue : MonoBehaviour
{
    public Dialogue2 dialogue;
    public States states;

    // Start is called before the first frame update
    void Start()
    {
        dialogue = GameObject.Find("PosGoTo").GetComponent<Dialogue2>();
        states = GameObject.Find("StateObject").GetComponent<States>();
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogue.hasFinished)
        {
            states.currentState = States.PlayerStates.Interact;
        }
    }

    private void OnMouseEnter()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(dialogue.Type());
            states.currentState = States.PlayerStates.Cutscene;
        }

    }
}
