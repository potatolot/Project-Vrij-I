using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerText : MonoBehaviour
{
    public Text TaskText;

    private void OnTriggerEnter(Collider other)
    {
        TaskText.text = "press left mouse button to interact";
    }

    private void OnTriggerExit(Collider other)
    {
        TaskText.text = "";
    }
}
