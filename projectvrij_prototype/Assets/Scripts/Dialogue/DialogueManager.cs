using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text nameText;
    public Text dialogueText;
    public ShowCanvas sc;
    States states;

    public bool isFinished = false;
 

    void Start()
    {
        sentences = new Queue<string>();

        sc = GameObject.Find("ExamineCanvas").GetComponent<ShowCanvas>();
        states = GameObject.Find("StateObject").GetComponent<States>();

    }

    public void StartDialogue(Dialogue dialogue)
    {
        states.currentState = States.PlayerStates.DialogueState;
        sc.showtheCanvas();
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        
        DisplayNextSentence();
        
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0) //end dialogue
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("end of convo");
        sc.gameObject.SetActive(false);
        isFinished = true;
    }
}
