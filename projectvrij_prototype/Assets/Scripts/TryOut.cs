using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TryOut : MonoBehaviour
{
    public Dialogue2 dialogue;

    // Start is called before the first frame update
    void Start()
    {
        dialogue = GameObject.Find("StoveDialogue").GetComponent<Dialogue2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogue.hasFinished)
        {
            StartCoroutine(TeleportIW());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(dialogue.Type());
    }

    IEnumerator TeleportIW()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("ProtectorScene");
    }
}
