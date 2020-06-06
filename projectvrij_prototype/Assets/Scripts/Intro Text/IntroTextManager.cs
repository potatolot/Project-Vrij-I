using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroTextManager : MonoBehaviour
{
    Dialogue2 dialogue2;
    // Start is called before the first frame update
    void Start()
    {
        dialogue2 = GameObject.Find("DialogueIntro").GetComponent<Dialogue2>();
        
    }

    private void Awake()
    {
        Dialogue();
    }

    void Dialogue()
    {
        StartCoroutine(dialogue2.Type());
    }
}
