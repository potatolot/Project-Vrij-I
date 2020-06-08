using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController player;
   
    public float speed = 12f;

    public bool isActive;
    bool isMoving = false;
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
        MovementSound();

    }
    void MovementSound()
    {
        //if (Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical"))
        //{
        //    GetComponent<AudioSource>().Play();
        //    GetComponent<AudioSource>().volume = Random.Range(0.8f, 1.1f);
        //    GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.2f);
        //}
            
        //else if (!Input.GetButton("Horizontal") && !Input.GetButton("Vertical") && GetComponent<AudioSource>().isPlaying)
        //{
        //    GetComponent<AudioSource>().Stop(); // or Pause()

        //}
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
    


