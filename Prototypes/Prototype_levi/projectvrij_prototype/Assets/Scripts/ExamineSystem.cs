using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamineSystem : MonoBehaviour
{
    GameObject ExamineBox;
    bool visible = false;
 

    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        ExamineBox = GameObject.Find("ExamineBox");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showExamine()
    {
        visible = !visible;
        ExamineBox.gameObject.SetActive(visible);

    }
}
