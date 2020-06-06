using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinDialogue : MonoBehaviour
{
    public Dialogue2 dialogue2;
    Bin bin;
    // Start is called before the first frame update
    void Start()
    {
        dialogue2 = GameObject.Find("BinDialogueTrigger").GetComponent<Dialogue2>();
        bin = GameObject.Find("ColliderBin").GetComponent<Bin>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && bin.amountHeld >= 3)
        {
            StartCoroutine(dialogue2.Type());
        }
    }
}
