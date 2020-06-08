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

    // Property that manages new puzzle pieces
    public int pieces
    {
        get { return PiecesHolding; }
        set
        {           
            if(PiecesHolding != value)
            {
                ManageUI(PiecesHolding, value);
                PiecesHolding = value;                
            }
        }
    }

    public void Update()
    {
        print(PiecesHolding);
    }


    // Adds when a new puzzle piece is added
    private void ManageUI(int currentPieces, int newPieces)
    {
        /*if (newPieces < currentPieces)
            RemovePuzzleSprite(currentPieces - newPieces);*/

        /*if(currentPieces < newPieces)
            AddPuzzleSprite()*/
    }

    private void AddPuzzleSprite(int pieceIndex)
    {
        puzzleCanvas.AddComponent<Image>().sprite = puzzleTexture;
        puzzleCanvas.AddComponent<Image>().gameObject.transform.position = new Vector2(pieceIndex * 64, 64);
    }

    private void RemovePuzzleSprite(int amount)
    {
        for(int i = 0; i < amount; i++)
        {
            Destroy(puzzleCanvas.GetComponents<Image>()[i]);
        }
    }

    
}
