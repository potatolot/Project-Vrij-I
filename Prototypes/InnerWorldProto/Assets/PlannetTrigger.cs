using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlannetTrigger : MonoBehaviour
{
    private bool isConnected = false;

    [SerializeField]
    private Canvas connectionCanvas;

    [SerializeField]
    private Canvas textCanvas;

    

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "planet")
        {
            if (!isConnected)
            {
                print("it's not connected");
                connectionCanvas.enabled = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    isConnected = true;
                    connectionCanvas.enabled = false;
                }
            }
            else
            {
                textCanvas.GetComponentInChildren<Text>().text = other.GetComponent<Planet>().GetText();
                
            }

            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isConnected = false;
        connectionCanvas.enabled = false;
        textCanvas.enabled = false;
    }

}
