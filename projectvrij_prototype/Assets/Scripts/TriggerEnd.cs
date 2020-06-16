using EPOOutline;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnd : MonoBehaviour
{
    public GameObject PlateDialogue;
    public GameObject PlatePos;
    public GameObject PlateEgg;
    public GameObject Plate;

    bool PlateHit = false;

    private void Awake()
    {
        PlateDialogue.SetActive(false);
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
    void OnTriggerExit(Collider other)
    {
        PlatePos.gameObject.tag = "Finish";
        
        PlateHit = false;
        Plate.GetComponent<Outlinable>().enabled = false;
    }
    void Update()
    {
        if(PlateHit)
        {
            StartCoroutine(FadetoBlack());
            //set active dialogue
            PlateDialogue.SetActive(true);
        }
    }

    IEnumerator FadetoBlack()
    {
        yield return new WaitForSeconds(3f);
        
        SceneManager.LoadScene("ThirdApartment");
    }
}
