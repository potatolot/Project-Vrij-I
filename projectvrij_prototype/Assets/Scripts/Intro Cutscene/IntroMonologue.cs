using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroMonologue : MonoBehaviour
{
    ShowCanvas showcanvas;
    Dialogue2 dialogue2;
    States states;
    GameObject intro;
    EmilyDoor Door;

    // Start is called before the first frame update
    void Start()
    {
        showcanvas = GameObject.Find("ExamineCanvas").GetComponent<ShowCanvas>();
        dialogue2 = GameObject.Find("Introduction").GetComponent<Dialogue2>();
        states = GameObject.Find("StateObject").GetComponent<States>();
        intro = GameObject.Find("Introduction");
        Door = GameObject.Find("Door_Leftswing (2)").GetComponent<EmilyDoor>();
    }

    void Update()
    {
        if (dialogue2.hasFinished)
        {
            intro.SetActive(false);
            //Door.enabled = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
 
        StartCoroutine(dialogue2.Type());
   
    }

    
}
