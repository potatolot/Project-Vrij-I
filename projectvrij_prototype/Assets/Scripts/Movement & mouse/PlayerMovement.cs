﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController player;
   
    public float speed = 12f;

    public bool isActive;
    bool isMoving = false;

    public AudioSource footsteps;
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
            MovementSound();

        }
        //if(footsteps.isPlaying && !isActive)
        //{
        //    footsteps.Stop();
        //}

    }
    void MovementSound()
    {
        if (Input.GetButtonDown("Vertical"))
        {
            footsteps.Play();
            //footsteps.volume = Random.Range(0.8f, 1.1f);
            //footsteps.pitch = Random.Range(0.8f, 1.2f);
            Debug.Log("i'm playing");
        }

        else if (!Input.GetButton("Horizontal") && !Input.GetButton("Vertical") && footsteps.isPlaying)
        {
            footsteps.Stop(); // or Pause()

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
    


