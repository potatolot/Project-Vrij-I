using EPOOutline;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnd : MonoBehaviour
{
    public GameObject PlatePos;
    public GameObject PlateEgg;
    public GameObject Plate;

    bool PlateHit = false;

    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "PlateEgg")
        {
            PlatePos.gameObject.tag = "fribg";
            PlateEgg.transform.position = PlatePos.transform.position;
            PlateHit = true;
            Plate.GetComponent<Outlinable>().enabled = false;
        }

    }

    void Update()
    {
        if(PlateHit)
        {
            StartCoroutine(FadetoBlack());

        }
    }

    IEnumerator FadetoBlack()
    {
        yield return new WaitForSeconds(1.5f);
        //
        SceneManager.LoadScene("ThirdApartment");
    }
}
