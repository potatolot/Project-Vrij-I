 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialogue : MonoBehaviour
{
    public Dialogue2 dialogue;

    InnerWorldStart iwstart;

    public bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        dialogue = GameObject.Find("PosGoTo").GetComponent<Dialogue2>();
        iwstart = GameObject.Find("IWstartCutscene").GetComponent<InnerWorldStart>();
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogue.hasFinished)
        {
            StartCoroutine(iwstart.GotoScreen());
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "alex")
        {
            triggered = true;
            StartCoroutine(dialogue.Type());
        }

         
        

    }
}
