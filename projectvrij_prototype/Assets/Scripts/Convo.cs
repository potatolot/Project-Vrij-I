using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Convo : MonoBehaviour
{

    DialogueManager dialoguemanager;
    // Start is called before the first frame update
    void Start()
    {
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
            //displaynextsentence
            dialoguemanager.DisplayNextSentence();
        }
    }
}
