using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowTaskText : MonoBehaviour
{
    public Text TaskText;


    void OnTriggerEnter(Collider other)
    {
        TaskText.text = "press left mouse button to interact";
    }
    void OnTriggerExit(Collider other)
    {
        TaskText.text = "";
    }
}
