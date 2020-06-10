using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class InnerWorldStart : MonoBehaviour
{
    public GameObject Alex;
    public GameObject PosGoTo;
    public GameObject ScreenPos;

    public States states;

    TriggerDialogue td;

    public float t = 0f;
    public float speedLerp = 0.01f;
    public float duration = 1000;

    // Start is called before the first frame update
    void Start()
    {
        states = GameObject.Find("StateObject").GetComponent<States>();
        td = GameObject.Find("PosGoTo").GetComponent<TriggerDialogue>();
    }

    void Awake()
    {
        states.currentState = States.PlayerStates.Cutscene;
        StartCoroutine(GotoPlayer());

        if(td.triggered)
        {
            PosGoTo.SetActive(false);
        }
    }

    IEnumerator GotoPlayer()
    {
        yield return new WaitForSeconds(0.5f);
        float current = 0;

        while (current < duration)
        {
            t = Mathf.InverseLerp(0, duration, current);
            Alex.transform.position = Vector3.Lerp(Alex.transform.position, PosGoTo.transform.position, t);
            current += Time.deltaTime * 4;
            yield return null;
        }
    }

    public IEnumerator GotoScreen()
    {
        yield return new WaitForSeconds(0.5f);
        states.currentState = States.PlayerStates.Interact;
        float current = 0;

        while (current < duration)
        {
            t = Mathf.InverseLerp(0, duration, current);
            Alex.transform.position = Vector3.Lerp(Alex.transform.position, ScreenPos.transform.position, t);
            current += Time.deltaTime;
            yield return null;
        }
    }
}
