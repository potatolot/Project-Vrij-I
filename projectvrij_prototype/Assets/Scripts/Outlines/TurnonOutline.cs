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

    Outlinable paper1;
    Outlinable paper2;
    Outlinable paper3;
    Outlinable bin;

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
        paper1 = GameObject.Find("papierprop").GetComponent<Outlinable>();
        paper2 = GameObject.Find("papierprop2").GetComponent<Outlinable>();
        paper3 = GameObject.Find("papierprop3").GetComponent<Outlinable>();
        bin = GameObject.Find("bin").GetComponent<Outlinable>();

        //I'm sure I could use an array for this but... it didn't work 
    }
    private void Awake()
    {
     
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

    public void turnOnOutlinesIntroObjects()
    {
        bin.enabled = true;
        paper1.enabled = true;
        paper2.enabled = true;
        paper3.enabled = true;
    }
}
