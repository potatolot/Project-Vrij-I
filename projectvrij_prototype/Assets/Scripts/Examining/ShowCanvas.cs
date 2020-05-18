using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using UnityEngine.UI;
public class ShowCanvas: MonoBehaviour
{
    private Canvas ExamineCanvas; 

    bool visible = false;

    void Awake()
    {
        visible = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        ExamineCanvas = GetComponent<Canvas>();
        ExamineCanvas.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showtheCanvas()
    {
        visible = !visible;
        ExamineCanvas.gameObject.SetActive(visible);

    }
}
