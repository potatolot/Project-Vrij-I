using EPOOutline;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
public class Bin : MonoBehaviour
{
    public AudioSource PaperFall;
    public int amountHeld;
    public Text TaskText;
    EmilyDoor Door;
    Outlinable bin;
    Outlinable paper1;
    Outlinable paper2;
    Outlinable paper3;
    Outlinable laylaDoor;
    Dialogue2 dialogue2;

    bool hasPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        Text TaskText = GameObject.Find("TaskText").GetComponent<Text>();
        Door = GameObject.Find("Door").GetComponent<EmilyDoor>();
        bin = GameObject.Find("bin").GetComponent<Outlinable>();

        paper1 = GameObject.Find("papierprop").GetComponent<Outlinable>();
        paper2 = GameObject.Find("papierprop2").GetComponent<Outlinable>();
        paper3 = GameObject.Find("papierprop3").GetComponent<Outlinable>();
        laylaDoor = GameObject.Find("Cutscene_Door").GetComponent<Outlinable>();

        dialogue2 = GameObject.Find("bin").GetComponent<Dialogue2>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (amountHeld >= 3)
        {
            Debug.Log("yay");
            Door.enabled = true;
            laylaDoor.enabled = true;
            bin.enabled = false;
            paper1.enabled = false;
            paper2.enabled = false;
            paper3.enabled = false;

            if (!hasPlayed)
            {
                StartCoroutine(dialogue2.Type());
                TaskText.text = "";
                hasPlayed = true;
                
            }
             
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Finish")
        {
            amountHeld++;
            PaperFall.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            amountHeld--;
        }
    }
}
