using EPOOutline;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnonOutline : MonoBehaviour
{
    StartCutscene doorCutscene;

    Outlinable outlinepan;
    Outlinable outlineegg;
    Outlinable stoveknob;

    BakeEggCutscene bakeegg;
    // Start is called before the first frame update
    void Start()
    {
        doorCutscene = GameObject.Find("Cutscene_Door").GetComponent<StartCutscene>();
        outlinepan = GameObject.Find("pan").GetComponent<Outlinable>();
        outlineegg = GameObject.Find("EggShell").GetComponent<Outlinable>();
        bakeegg = GameObject.Find("StoveTrigger").GetComponent<BakeEggCutscene>();
        stoveknob = GameObject.Find("StoveKnob").GetComponent<Outlinable>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(doorCutscene.DoorCutsceneDone)
        {
            outlinepan.enabled = true;
            outlineegg.enabled = true;
        }

        if (bakeegg.panHit)
        {
            outlinepan.enabled = false;
        }

        if (bakeegg.eggHit)
        {
            stoveknob.enabled = true;
        }

    }
}
