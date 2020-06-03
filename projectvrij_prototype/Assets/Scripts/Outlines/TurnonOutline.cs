using EPOOutline;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnonOutline : MonoBehaviour
{
    ContinueLaylaCutscene doorCutscene;

    Outlinable outlinepan;
    Outlinable outlineegg;
    Outlinable stoveknob;
    Outlinable outlinedoor;

    BakeEggCutscene bakeegg;
    // Start is called before the first frame update
    void Start()
    {
        doorCutscene = GameObject.Find("Cutscene_Door").GetComponent<ContinueLaylaCutscene>();
        outlinedoor = GameObject.Find("Cutscene_Door").GetComponent<Outlinable>();
        outlinepan = GameObject.Find("pan").GetComponent<Outlinable>();
        outlineegg = GameObject.Find("EggShell").GetComponent<Outlinable>();
        bakeegg = GameObject.Find("StoveTrigger").GetComponent<BakeEggCutscene>();
        stoveknob = GameObject.Find("StoveKnob").GetComponent<Outlinable>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(doorCutscene.CutsceneDone)
        {
            outlinepan.enabled = true;
            outlineegg.enabled = true;

            outlinedoor.enabled = false;
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
