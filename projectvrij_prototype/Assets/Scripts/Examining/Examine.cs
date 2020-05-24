using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Examine : MonoBehaviour
{
    GameObject ExamineText;
    GameObject PlayerObject;

    ShowCanvas showcanvas;

    States states;

    float minDistanceToObject = 10;

    // Start is called before the first frame update
    void Start()
    {
        //game objects 
        PlayerObject = GameObject.Find("Player");

        ExamineText = GameObject.Find("ExamineText");

        showcanvas = GameObject.Find("ExamineCanvas").GetComponent<ShowCanvas>();

        states = GameObject.Find("StateObject").GetComponent<States>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseOver()
    {
        float distance = Vector3.Distance(this.transform.position, PlayerObject.transform.position);

        if (Input.GetKeyDown(KeyCode.E) && distance < minDistanceToObject)
        {
            //showExamine();
            ExamineText.GetComponentInChildren<Text>().text = this.GetComponentInChildren<ShowText>().GetText();
            showcanvas.showtheCanvas();
            
        }
       
    }

}
