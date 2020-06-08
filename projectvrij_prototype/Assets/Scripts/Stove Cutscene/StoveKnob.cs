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
    public GameObject stovedialogue;
    StoveDialogue stovedialoguescript;
    ParticleSystem particles;

    EnableStoveDialogue enablestoved;

    public AudioSource fire;
    public AudioSource fryingegg;
    public AudioSource gasburner;
    // Start is called before the first frame update
    void Start()
    {
        
        cutscene = GameObject.Find("StoveTrigger").GetComponent<BakeEggCutscene>();
        states = GameObject.Find("StateObject").GetComponent<States>();
        dialogue2 = GameObject.Find("StoveKnob").GetComponent<Dialogue2>();
        StoveCutsceneTriggered = false;
        stovedialogue = GameObject.Find("StoveDialogue");
        stovedialoguescript = GameObject.Find("StoveKnob").GetComponent<StoveDialogue>();
        //particles = GameObject.Find("ParticleSystem").GetComponent<ParticleSystem>();
        enablestoved = GameObject.Find("StoveDialogueP").GetComponent<EnableStoveDialogue>();
        

    }

    void OnMouseOver()
    {
        if(Input.GetKeyDown(KeyCode.E) && cutscene.eggHit)
        {
            //particles.Play();
            stovedialoguescript.StartDialogue();
            states.currentState = States.PlayerStates.DialogueState;
            gasburner.Play();
            StartCoroutine(Sound());
        }
    }
    IEnumerator Sound()
    {
        yield return new WaitForSeconds(0.3f);
        fryingegg.Play();
        fire.Play();
        
    }
    
    IEnumerator Vignetting()
    {
        yield return new WaitForSeconds(2);
        //start vignetting
    }
}
