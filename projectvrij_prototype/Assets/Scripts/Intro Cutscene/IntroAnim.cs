using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAnim : MonoBehaviour
{
    Camera IntroCam;
    Camera MainCamera;
    GameObject Player;
    Animator IntroAnimAnimator;
    // Start is called before the first frame update
    void Start()
    {
        MainCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        IntroCam = GameObject.Find("IntroCam").GetComponent<Camera>();
        Player = GameObject.Find("Player");
        IntroAnimAnimator = gameObject.GetComponent<Animator>();
    }

    private void Awake()
    {
        MainCamera.enabled = false;
        IntroCam.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (IntroAnimAnimator.GetBool("isGoing"))
        {
           
        }
    }

    //if intro camera animation is done
    //enable player camera 
    //setactive player 
}
