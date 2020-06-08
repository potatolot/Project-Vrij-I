using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StoveDialogue : MonoBehaviour
{
    bool dialogueStoveStarted = false;
    public Dialogue2 dialogue2;
    public AudioSource breathing;

    public Camera maincam;
    public ParticleSystem fire;
    public float maxFOV = 800f;
    public float t = 0f;
    public float speedLerp = 0.01f;
    public float duration = 1000;
    // Start is called before the first frame update
    void Start()
    {
        dialogue2 = GameObject.Find("StoveKnob").GetComponent<Dialogue2>();
        StopAllCoroutines();
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogue2.hasFinished && dialogueStoveStarted)
        {
            StartCoroutine(TeleportIW());
        }
    }
    IEnumerator Lerpie()
    {
        yield return new WaitForSeconds(1);
        float current = 0;

        while (current < duration)
        {
            t = Mathf.InverseLerp(0, duration, current);
            maincam.fieldOfView = Mathf.Lerp(maincam.fieldOfView, maxFOV, t);
            current += Time.deltaTime / 5;
            yield return null;
        }
    }
    public void StartDialogue()
    {
        fire.Play();

        StartCoroutine(dialogue2.Type());
        dialogueStoveStarted = true;
        StartCoroutine(Lerpie());
        StartCoroutine(FreakingOut());
        
    }
           
    IEnumerator FreakingOut()
    {
        yield return new WaitForSeconds(1f);
        breathing.Play();
    }
    IEnumerator TeleportIW()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("ProtectorScene");
    }
}
