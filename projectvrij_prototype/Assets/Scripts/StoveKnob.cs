using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoveKnob : MonoBehaviour
{
    BakeEggCutscene cutscene;
    public DialogueTrigger dialoguetrigger;
    DialogueManager dialoguemanager;
    States states;

    // Start is called before the first frame update
    void Start()
    {
        cutscene = GameObject.Find("StoveTrigger").GetComponent<BakeEggCutscene>();
        states = GameObject.Find("StateObject").GetComponent<States>();
        dialoguemanager = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();

    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void OnMouseOver()
    {
        if(Input.GetKeyDown(KeyCode.E) && cutscene.eggHit)
        {
            Debug.Log("turnon");
            states.currentState = States.PlayerStates.Cutscene;
            StartCoroutine(DialogueStove());
        }
    }

    IEnumerator DialogueStove()
    {
        yield return new WaitForSeconds(4);
        dialoguetrigger.TriggerDialogue();
        StartCoroutine(TeleportIW());
    }
    IEnumerator TeleportIW()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("InnerWorld");
    }
}
