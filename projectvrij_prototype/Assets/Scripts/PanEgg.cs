using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanEgg : MonoBehaviour
{
    BakeEggCutscene eggcutscene;
    // Start is called before the first frame update
    void Start()
    {
        eggcutscene = GameObject.Find("StoveTrigger").GetComponent<BakeEggCutscene>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "EggShell" && eggcutscene.panHit)
        {
            eggcutscene.eggHit = true;
        }
    }
}
