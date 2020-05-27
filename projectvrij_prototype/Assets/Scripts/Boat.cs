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
    [SerializeField] private AudioClip audio;
    [SerializeField] private BoatBehaviour behaviour;
    [Range(0.0f, 100.0f)] [SerializeField] private float speed;
    private Vector3 startPosition;

    // Sets audio clip to audio
    private void Start()
    {
        GetComponent<AudioSource>().clip = audio;
        startPosition = transform.position;
    }

    // When player enters the collision box it plays the audio
    private void OnTriggerEnter(Collider other)
    {
        // Plays the audio if it isn't playing already
        if(!GetComponent<AudioSource>().isPlaying)
                GetComponent<AudioSource>().Play();        
    }

    private void OnTriggerStay(Collider other)
    {
                // Checks whether the boat will flee
        if (behaviour == BoatBehaviour.FleeWhenNear)
        {
            float step = speed * Time.deltaTime;
            Vector3 endPos = new Vector3(0, 0, 400);
            transform.LookAt(transform.position + (other.transform.forward * 200f));
            transform.Rotate(0, 0, -90f);
            transform.position += transform.forward * step;
        }
    }

}
