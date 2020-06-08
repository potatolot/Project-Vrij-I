using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BoatBehaviour
{
    Idle,
    FleeWhenNear
}

public class Boat : MonoBehaviour
{
    [SerializeField]                            private AudioClip audio;
    [SerializeField]                            private BoatBehaviour behaviour;
    [Range(0.0f, 100.0f)] [SerializeField]      private float speed;
    
    [SerializeField]                            bool HoldsPuzzle = false;

                                                // Puzzle checks
                                                private bool playerEntered = false;
                                                private bool pieceCollected = false;
                                                
                                                // Start position of the boat 
                                                private Vector3 startPosition;
                                                

    // Sets audio clip to audio
    private void Start()
    {
        GetComponent<AudioSource>().clip = audio;
        startPosition = transform.position;
    }

    private void Update()
    {
        //Checks if player is collecting the puzzle piece
        if (playerEntered && Input.GetKeyDown(KeyCode.C) && HoldsPuzzle)
        {
            HoldsPuzzle = false;
            pieceCollected = true;
        }
    }

    // When player enters the collision box it plays the audio
    private void OnTriggerEnter(Collider other)
    {
        // Plays the audio if it isn't playing already
        if(!GetComponent<AudioSource>().isPlaying)
                GetComponent<AudioSource>().Play();

        playerEntered = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playerEntered = false;
    }

    private void OnTriggerStay(Collider other)
    {
                // Checks whether the boat will flee
        if (behaviour == BoatBehaviour.FleeWhenNear)
        {
            float step = speed * Time.deltaTime;
            Vector3 lookAt = transform.position + (other.transform.forward * 200f);
            Quaternion lookAtRotation = Quaternion.LookRotation(lookAt);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, lookAtRotation, 300f * Time.deltaTime);
            transform.position += transform.forward * step;
        }

        if(pieceCollected)
        {
            other.GetComponent<PlayerPuzzelHandler>().AddPiece();
            print("Jup");

            pieceCollected = false;
        }
    }

}
