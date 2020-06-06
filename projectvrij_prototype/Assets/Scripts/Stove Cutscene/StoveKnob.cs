using EPOOutline;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoveKnob : MonoBehaviour
{
    BakeEggCutscene cutscene;
    States states;
    bool StoveCutsceneTriggered;
    Dialogue2 dialogue2;
    GameObject stovedialogue;
    StoveDialogue stovedialoguescript;
    
    // Start is called before the first frame update
    void Start()
    {
        cutscene = GameObject.Find("StoveTrigger").GetComponent<BakeEggCutscene>();
        states = GameObject.Find("StateObject").GetComponent<States>();
        dialogue2 = GameObject.Find("StoveKnob").GetComponent<Dialogue2>();
        StoveCutsceneTriggered = false;
        stovedialogue = GameObject.Find("StoveDialogue");
        stovedialoguescript = GameObject.Find("StoveDialogue").GetComponent<StoveDialogue>();
        
        stovedialogue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (StoveCutsceneTriggered)
        {
            stovedialogue.SetActive(true);
            StopAllCoroutines();
            

        }
    }

    void OnMouseOver()
    {
        if(Input.GetKeyDown(KeyCode.E) && cutscene.eggHit)
        {
            Debug.Log("turnon");
            StoveCutsceneTriggered = true;
            FindObjectOfType<AudioManager>().Play("Gasburner");
            states.currentState = States.PlayerStates.DialogueState;
            FindObjectOfType<AudioManager>().Play("FryingEgg");
            FindObjectOfType<AudioManager>().Play("Fire");
        }
    }

    IEnumerator Vignetting()
    {
        yield return new WaitForSeconds(2);
        //start vignetting
    }
}
