using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class ExamineSystem : MonoBehaviour
{
    private Canvas ExamineCanvas; // Assign in inspector
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

    public void showExamine()
    {
        visible = !visible;
        ExamineCanvas.gameObject.SetActive(visible);

    }
}
