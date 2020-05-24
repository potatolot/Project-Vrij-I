using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCutscene : MonoBehaviour
{
    StartCutscene cutscene;

    private void Start()
    {
        cutscene = GameObject.Find("Cutscene_Door").GetComponent<StartCutscene>();

    }
    private void OnTriggerEnter(Collider other)
    {
        cutscene.CutsceneTriggered();
    }
}
