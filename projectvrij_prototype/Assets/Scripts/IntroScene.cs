using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IntroScene: MonoBehaviour
{
    public Dialogue2 dialogue2;

    void Update()
    {
        if (dialogue2.hasFinished)
        {
            StartCoroutine(Teleport());
        }

    }
    void Awake()
    {
        StartCoroutine(dialogue2.Type());
    }

    IEnumerator Teleport()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Apartment");
    }
}
