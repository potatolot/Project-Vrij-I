using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActive : MonoBehaviour
{

    private void Awake()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }

    public void ActivateIntroduction()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }

    public void DeactivateIntro()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
