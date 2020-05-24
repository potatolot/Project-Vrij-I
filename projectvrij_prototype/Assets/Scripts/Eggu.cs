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

        GameObject.Find("Egg").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ShowEgg()
    {
        GameObject.Find("Egg").SetActive(true);
        Debug.Log("showeg");
    }
}
