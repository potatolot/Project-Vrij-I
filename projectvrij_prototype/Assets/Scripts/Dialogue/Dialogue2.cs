﻿using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialogue2 : MonoBehaviour
{
    public string[] sentencesD;
    private int index;
    public float typingSpeed;
    public Text DText;
    public bool hasFinished = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && DText.text == sentencesD[index]) //if press e and the displayed text is equal to current sentence
        {
            NextSentence();
        }
    }

    public IEnumerator Type()
    {
        
        hasFinished = false;
        foreach (char letter in sentencesD[index].ToCharArray())
        {
            FindObjectOfType<AudioManager>().Play("Typewriter");
            DText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    public void NextSentence()
    {

        if (index < sentencesD.Length - 1)
        {
            index++;
            DText.text = "";
            StartCoroutine(Type());
        }
        else
        {
            DText.text = "";
            hasFinished = true;
   

        }
    }

}
