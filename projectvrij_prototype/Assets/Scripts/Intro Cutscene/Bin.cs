using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
public class Bin : MonoBehaviour
{
    public Dialogue2 dialogue2;
    int amountHeld;
    public Text TaskText;
    EmilyDoor Door;
    // Start is called before the first frame update
    void Start()
    {
        Text TaskText = GameObject.Find("TaskText").GetComponent<Text>();
        Door = GameObject.Find("Door").GetComponent<EmilyDoor>();
        dialogue2 = GameObject.Find("ColliderBin").GetComponent<Dialogue2>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(amountHeld);
        if (amountHeld >= 3)
        {
            Debug.Log("yay");
            Door.enabled = true;
            TaskText.text = "";
            StopAllCoroutines();
           

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "paper")
        {
            amountHeld++;
        }
    }
}
