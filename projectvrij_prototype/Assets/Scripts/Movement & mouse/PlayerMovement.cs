using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController player;
   
    public float speed = 12f;

    public bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        isActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive)
        {
            Move();
        }
    }

    void Move()
    {
        //movement input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //walcc
        Vector3 move = transform.right * x + transform.forward * z;

        player.Move(move * speed * Time.deltaTime);
    }
}
    


