using EPOOutline;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class IntroMonologue : MonoBehaviour
{
    Dialogue_Auto dialogue;
    EmilyDoor Door;
    public Text TaskText;
    GameObject Introduction;

    TriggerActive ta;


    bool FirstCollision = false;
    // Start is called before the first frame update
    void Start()
    {
        dialogue = GameObject.Find("Introduction").GetComponent<Dialogue_Auto>();
        Door = GameObject.Find("EmilyDoor").GetComponent<EmilyDoor>();
        Text TaskText = GameObject.Find("TaskText").GetComponent<Text>();
        Introduction = GameObject.Find("Introduction");
        ta = GameObject.Find("IntroductionParent").GetComponent<TriggerActive>();
    }

    void Update()
    {
        if (dialogue.hasFinished)
        {
            ta.DeactivateIntro();

            TaskText.text = "Press 'E' to pick up items";
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && FirstCollision == false)
        {
            StartCoroutine(dialogue.Type());
            FirstCollision = true;
            
        }
    }

}
