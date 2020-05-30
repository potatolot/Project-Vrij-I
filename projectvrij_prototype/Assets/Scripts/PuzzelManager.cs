using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PuzzelManager : MonoBehaviour
{
    // list with puzzleparts
    [SerializeField] private List<PuzzelPiece> puzzelParts = new List<PuzzelPiece>();

    private bool triggered = false;

    private bool playerHoldsPiece;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggered/* && playerHoldsPiece*/)
        {
            for (int i = 0; i < puzzelParts.Count; i++)
            {
                //Checks whether the puzzle piece is not yet visible
                if (!puzzelParts[i].isVisible)
                {
                    //Makes the puzzle piece visible
                    puzzelParts[i].isVisible = true;
                    playerHoldsPiece = false;
                    break;
                }
            }
        }
    }

    // Sets triggered to true when another gameobject enters the collisonbox
    private void OnTriggerEnter(Collider other)
    {
        //player holds piece = other.GetComponent<Script>().checkifpiece
        triggered = true;
    }

    private void OnTriggerExit(Collider other)
    {
        //other.GetComponent<Script>().checkifpiece = playerHoldsPiece;
        triggered = false;
    }
}
