using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]
public class PuzzelManager : MonoBehaviour
{
    public Text TaskText;
    public GameObject PuzzlePos;
    // list with puzzleparts
    [SerializeField] private List<PuzzelPiece> puzzelParts = new List<PuzzelPiece>();

    private bool triggered = false;

    private int playerPieces = 0;
    private int piecesVisible = 0;

    private void Awake()
    {
        PuzzlePos.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0) && triggered)
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
        {
            SceneManager.LoadScene("SecondApartment");
        }
            
        else
        {
            piecesVisible = 0;
        }
           
        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene("SecondApartment");
        }
        
    }
    
    private void OnTriggerStay(Collider other)
    {
        //Updates the amount of player pieces
        other.GetComponent<PlayerPuzzelHandler>().pieces = playerPieces;
    }

    // Sets triggered to true when another gameobject enters the collisonbox
    private void OnTriggerEnter(Collider other)
    {
        playerPieces = other.GetComponent<PlayerPuzzelHandler>().pieces;
        // other.GetComponent<PlayerPuzzelHandler>().pieces = 0;
        triggered = true;
    }

    private void OnTriggerExit(Collider other)
    {
        //  other.GetComponent<PlayerPuzzelHandler>().pieces = playerPieces;
        triggered = false;
    }
}
