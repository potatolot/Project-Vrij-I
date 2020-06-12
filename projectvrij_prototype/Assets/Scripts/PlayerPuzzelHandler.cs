using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPuzzelHandler : MonoBehaviour
{
    // Amount of puzzle player 
    private int PiecesHolding = 0;

    // Canvas that shows puzzle pieces
    [SerializeField] private GameObject puzzleCanvas;

    // Puzzle Texture
    [SerializeField] private Sprite puzzleTexture;

    [SerializeField] private int maxPieces = 4;

    // Property that manages new puzzle pieces
    public int pieces
    {
        get { return PiecesHolding; }
        set
        {           
            if(PiecesHolding != value)
            {
                PiecesHolding = value;
                ManageUI(PiecesHolding);                               
            }
        }
    }
    
    public void Update()
    {
        print(PiecesHolding);
    }


    // Adds when a new puzzle piece is added
    private void ManageUI(int newPieces)
    {
        puzzleCanvas.GetComponentInChildren<Text>().text = newPieces.ToString() + "/" + maxPieces;
    }
    
}
