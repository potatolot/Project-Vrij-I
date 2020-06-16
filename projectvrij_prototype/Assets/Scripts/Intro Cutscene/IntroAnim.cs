using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAnim : MonoBehaviour
{
    public TurnoffPickup tpu;
    public Camera MainCamera, IntroCam;
    MSMoveObjects objectScript;
    GameObject Player;
    Animator IntroAnimAnimator;
    TriggerActive ta;
    bool hasEnded = false;
    void Start()
    {
        MainCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        IntroCam = GameObject.Find("IntroCam").GetComponent<Camera>();
        Player = GameObject.Find("Player");
        IntroAnimAnimator = gameObject.GetComponent<Animator>();
        ta = GameObject.Find("IntroductionParent").GetComponent<TriggerActive>();
        objectScript = GameObject.FindWithTag("MainCamera").GetComponent<MSMoveObjects>();
    }

    private void Awake()
    {
        MainCamera.enabled = false;
        IntroCam.enabled = true;
        //objectScript.enabled = false;
    }

    public void AnimationEnded()
    {
        //objectScript.enabled = true;
        IntroCam.enabled = false;
        MainCamera.enabled = true;
        if(!hasEnded)
        {
            ta.ActivateIntroduction();
            Debug.Log("animationend");
            hasEnded = true;
            tpu.disabledScript = false;
        }

    }


}
