using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableStoveDialogue : MonoBehaviour
{
    StoveKnob stoveknobscript;
    // Start is called before the first frame update
    void Start()
    {
       
        stoveknobscript = GameObject.Find("StoveKnob").GetComponent<StoveKnob>();

        transform.GetChild(0).gameObject.SetActive(false);
    }

}
