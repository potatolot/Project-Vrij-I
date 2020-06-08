﻿using EPOOutline;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BakeEggCutscene : MonoBehaviour
{
    public bool panHit = false;
    public bool eggHit = false;

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
        Egg = GameObject.Find("Egg");
        panOutline = GameObject.Find("pan").GetComponent<Outlinable>();
        EggShell = GameObject.Find("EggShell");
        stoveKnobOutline = GameObject.Find("StoveKnob").GetComponent<Outlinable>();
        PanHit = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(panHit)
        {
            panOutline.enabled = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pan")
        {
            panOutline.enabled = false;
            panHit = true;
            GameObject.Find("pan").GetComponent<PickUp>().enabled = false;
            GameObject.Find("pan").transform.position = panpos.transform.position;
            PanHit.Play();
            
        }

        if (other.gameObject.tag == "EggShell" && panHit)
        {
            
            eggHit = true;
            EggHit.Play();
            Egg.transform.position = GameObject.Find("EggPos").transform.position;
            EggShell.SetActive(false);
            Destroy(GameObject.FindWithTag("EggShell"));
            stoveKnobOutline.enabled = true;


        }


    }
 }
