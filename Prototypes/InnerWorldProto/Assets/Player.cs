using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float rotation = 0;

    private float speed = 20f;

    [SerializeField]
    private CharacterController controller;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * 300 * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * 300 * Time.deltaTime;

        rotation -= mouseY;        

        float rotationY = transform.localEulerAngles.y;
        rotation = Mathf.Clamp(rotation, -60, 60);


        transform.localEulerAngles = new Vector3(rotation, rotationY, 0f);
        transform.Rotate(0, mouseX, 0);

        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        controller.Move(movement);



    }
}
