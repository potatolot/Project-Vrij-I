using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DialogueEnd : MonoBehaviour
{
    public Dialogue2 dialogue;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowDialogue());
        GameObject.FindGameObjectWithTag("music").GetComponent<SoundStart>().PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogue.hasFinished)
        {
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator ShowDialogue()
    {
        yield return new WaitForSeconds(2);
        StartCoroutine(dialogue.Type());
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Laptop");
    }
}
