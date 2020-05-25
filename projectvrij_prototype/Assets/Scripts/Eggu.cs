using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggu : MonoBehaviour
{
    BakeEggCutscene cutscene;

    private void Start()
    {
        cutscene = GameObject.Find("StoveTrigger").GetComponent<BakeEggCutscene>();
    }
    private void Awake()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ShowEgg()
    {
        GameObject.Find("Egg").transform.position = GameObject.Find("StoveTrigger").transform.position;
        Debug.Log("showeg");
    }
}
