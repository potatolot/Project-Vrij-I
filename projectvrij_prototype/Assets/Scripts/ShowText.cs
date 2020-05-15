using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowText : MonoBehaviour
{
    GameObject ExaminableObj;
    GameObject ExamineText;

    Control control;
    // Start is called before the first frame update
    void Start()
    {
        ExamineText = GameObject.Find("ExamineText");
        ExaminableObj = GameObject.FindWithTag("examinable");
        control = GameObject.Find("Player").GetComponent<Control>();
    }

    // Update is called once per frame
    void Update()
    {
        ExamineText.GetComponentInChildren<Text>().text = ExaminableObj.GetComponentInChildren<TextEx>().GetText();
    }
}
