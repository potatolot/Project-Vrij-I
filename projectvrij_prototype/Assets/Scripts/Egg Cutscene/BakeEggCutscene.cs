using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BakeEggCutscene : MonoBehaviour
{
    public bool panHit = false;
    public bool eggHit = false;
    GameObject Egg;

    GameObject panpos;
    // Start is called before the first frame update
    void Start()
    {
        panpos = GameObject.Find("PanPos");
        Egg = GameObject.Find("Egg");
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
            GameObject.Find("pan").transform.position = panpos.transform.position;
        }

        if (other.gameObject.tag == "EggShell" && panHit)
        {
            Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            eggHit = true;
            Egg.transform.position = GameObject.Find("EggPos").transform.position;
            Destroy(GameObject.FindWithTag("EggShell"));

        }

    }
 }

