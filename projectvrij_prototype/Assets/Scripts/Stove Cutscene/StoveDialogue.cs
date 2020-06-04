using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StoveDialogue : MonoBehaviour
{
    bool dialogueStoveStarted = false;
    Dialogue2 dialogue2;
    // Start is called before the first frame update
    void Start()
    {
        dialogue2 = GameObject.Find("StoveDialogue").GetComponent<Dialogue2>();
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogue2.hasFinished && dialogueStoveStarted)
        {
            StartCoroutine(TeleportIW());
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(dialogue2.Type());
        dialogueStoveStarted = true;
    }
    
    
    IEnumerator TeleportIW()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("InnerWorld");
    }
}
