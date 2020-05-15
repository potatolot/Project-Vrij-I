using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowText : MonoBehaviour
{
    GameObject ExaminableObj;
    GameObject ExamineText;

    PlayerInput pinput;
    // Start is called before the first frame update
    void Start()
    {
        ExamineText = GameObject.Find("ExamineText");
        ExaminableObj = GameObject.FindWithTag("examinable");
        pinput = GameObject.Find("Player").GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        
        ExamineText.GetComponentInChildren<Text>().text = ExaminableObj.GetComponentInChildren<TextEx>().GetText();
    }
}
