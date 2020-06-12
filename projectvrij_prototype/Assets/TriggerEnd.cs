using EPOOutline;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnd : MonoBehaviour
{
    public GameObject PlatePos;
    public GameObject PlateEgg;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "finish")
        {
            PlatePos.gameObject.tag = "fribg";
            PlateEgg.transform.position = PlatePos.transform.position;
            PlatePos.GetComponent<Outlinable>().enabled = false;
            

        }
    }

    IEnumerator FadetoBlack()
    {
        yield return new WaitForSeconds(0.5f);
        //
    }
}
