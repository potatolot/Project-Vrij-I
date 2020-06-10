using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TryOut : MonoBehaviour
{
    public Dialogue2 dialogue2;

    // Start is called before the first frame update
    void Start()
    {
        dialogue2 = GameObject.Find("StoveDialogue").GetComponent<Dialogue2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogue2.hasFinished)
        {
            StartCoroutine(TeleportIW());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(dialogue2.Type());
    }

    IEnumerator TeleportIW()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("ProtectorScene");
    }
}
