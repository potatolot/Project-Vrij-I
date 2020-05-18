using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Teleport : MonoBehaviour
{
    GameObject PlayerObject;

    float minDistanceToObject = 10;
    void Start()
    {
        //game objects 
        PlayerObject = GameObject.Find("Player");

    }
    void Update()
    {

    }

    void OnMouseOver()
    {
        float distance = Vector3.Distance(this.transform.position, PlayerObject.transform.position);

        if (Input.GetKeyDown(KeyCode.E) && distance < minDistanceToObject)
        {
            SceneManager.LoadScene("InnerWorld"); //go to inner world 
        }
    }
    
}
