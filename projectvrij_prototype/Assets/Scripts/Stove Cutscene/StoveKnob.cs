using EPOOutline;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoveKnob : MonoBehaviour
{
    public GameObject PlayerObject;
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

    AudioSource MainMusic;

    float minDistanceToObject = 3;

    bool knobHit = false;
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

        MainMusic = GameObject.Find("House").GetComponent<AudioSource>();

    }

    void OnMouseOver()
    {
        float distance = Vector3.Distance(this.transform.position, PlayerObject.transform.position);

        if (Input.GetMouseButtonDown(0) && cutscene.eggHit && distance < minDistanceToObject && !knobHit)
        {
            //particles.Play();
            stovedialoguescript.StartDialogue();
            states.currentState = States.PlayerStates.DialogueState;
            gasburner.Play();
            MainMusic.pitch = -1.89f;
            StartCoroutine(Sound());
            knobHit = true;

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
