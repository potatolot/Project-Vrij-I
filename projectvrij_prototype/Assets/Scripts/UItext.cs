using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UItext : MonoBehaviour
{
    public string text;
    public GameObject TaskText;

    // Start is called before the first frame update
    void Start()
    {
        TaskText = GameObject.Find("TaskText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
