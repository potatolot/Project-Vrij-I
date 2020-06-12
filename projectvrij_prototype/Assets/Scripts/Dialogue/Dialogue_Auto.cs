using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialogue_Auto : MonoBehaviour
{
    public string[] sentencesD;
    private int index;
    public float typingSpeed;
    public Text DText;
    public bool hasFinished = false;

    private void Update()
    {
        if (DText.text == sentencesD[index]) //if displayed text is equal to current sentence
        {
            StartCoroutine(NextSentence());
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
    public IEnumerator NextSentence()
    {
        yield return new WaitForSeconds(1);

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
