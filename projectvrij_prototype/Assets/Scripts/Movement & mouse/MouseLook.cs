using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSens = 100f; //f is for float so it knows it's a float number

    public Transform playerBody; //reference for the player transform

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime; //gets the x axis of the mouse
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRotation -= mouseY; //decrease xRotation based on mouseY
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //makes it so you can't look behind the player

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //Quaternion is for rotation in Unity


        playerBody.Rotate(Vector3.up * mouseX); //rotate body with mouse X




    }


}