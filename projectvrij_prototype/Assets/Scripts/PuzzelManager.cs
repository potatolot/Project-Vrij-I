using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PuzzelManager : MonoBehaviour
{
    // list with puzzleparts
    [SerializeField] private List<PuzzelPiece> puzzelParts = new List<PuzzelPiece>();

    private bool triggered = false;

    private int playerPieces = 0;
    private int piecesVisible = 0;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggered)
        {
            foreach(PuzzelPiece piece in puzzelParts)
            {
                //Checks whether the puzzle piece is not yet visible
                if (!piece.isVisible && playerPieces != 0)
                {
                    //Makes the puzzle piece visible
                    piece.isVisible = true;
                    playerPieces--;
                    break;
                }
                else if (piece.isVisible)
                    piecesVisible++;

            }
        }

        if (piecesVisible == puzzelParts.Count)
            SceneManager.LoadScene("Apartment");
        else
            piecesVisible = 0;

        
    }

    // Sets triggered to true when another gameobject enters the collisonbox
    private void OnTriggerEnter(Collider other)
    {
        playerPieces = other.GetComponent<PlayerPuzzelHandler>().CheckPieces();
        other.GetComponent<PlayerPuzzelHandler>().SetPieces(0);
        triggered = true;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<PlayerPuzzelHandler>().SetPieces(playerPieces);
        triggered = false;
    }
}
