using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAnim : MonoBehaviour
{
    public Camera MainCamera, IntroCam;
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
    }

    private void Awake()
    {
        MainCamera.enabled = false;
        IntroCam.enabled = true;

    }

    public void AnimationEnded()
    {

        IntroCam.enabled = false;
        MainCamera.enabled = true;
        if(!hasEnded)
        {
            ta.ActivateIntroduction();
            Debug.Log("animationend");
            hasEnded = true;
        }
    }


}
