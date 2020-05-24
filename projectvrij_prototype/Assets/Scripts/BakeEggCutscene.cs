using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BakeEggCutscene : MonoBehaviour
{
    public bool panHit = false;
    public bool eggHit = false;


    Eggu panScript;

    // Start is called before the first frame update
    void Start()
    {
        panScript = GameObject.Find("pan").GetComponent<Eggu>();
    }

    private void Awake()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
  
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pan")
        {
            panHit = true;
            GameObject.Find("pan").GetComponent<PickUp>().enabled = false;

        }

        if (other.gameObject.tag == "EggShell" && panHit)
        {
            Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            eggHit = true;
            panScript.ShowEgg();

        }

    }
 }

