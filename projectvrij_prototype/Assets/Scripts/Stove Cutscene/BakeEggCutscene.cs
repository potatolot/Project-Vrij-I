using EPOOutline;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BakeEggCutscene : MonoBehaviour
{
    public bool panHit = false;
    public bool eggHit = false;

    GameObject pan;
    GameObject Egg;
    GameObject EggShell;
    GameObject panpos;

    Outlinable panOutline;
    Outlinable stoveKnobOutline;

    public AudioSource PanHit;
    public AudioSource EggHit;

    // Start is called before the first frame update
    void Start()
    {
        panpos = GameObject.Find("PanPos");
        Egg = GameObject.Find("Egg_Updated");
        panOutline = GameObject.Find("pan").GetComponent<Outlinable>();
        EggShell = GameObject.Find("EggShell");
        stoveKnobOutline = GameObject.Find("StoveKnob").GetComponent<Outlinable>();
        PanHit = GetComponent<AudioSource>();
        pan = GameObject.Find("pan");
    }

    // Update is called once per frame
    void Update()
    {
        if(panHit)
        {
            panOutline.enabled = false;
        }

        if(eggHit)
        {
            EggHit.Play();
            Egg.transform.position = GameObject.Find("EggPos").transform.position;
            EggShell.SetActive(false);
            Destroy(GameObject.FindWithTag("EggShell"));
            stoveKnobOutline.enabled = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "pan" && other.gameObject.tag == "Finish")
        {
            pan.transform.gameObject.tag = "pan";
            panOutline.enabled = false;
            panHit = true;
            pan.transform.position = panpos.transform.position;
            pan.transform.rotation = Quaternion.Euler(0, 180, 0);
            PanHit.Play();  
        }

        if (other.gameObject.name == "EggShell" && panHit)
        {
            
            eggHit = true;
        }


    }
 }

