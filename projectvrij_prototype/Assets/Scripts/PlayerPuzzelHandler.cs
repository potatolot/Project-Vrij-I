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
        if (newPieces < currentPieces)
        {
            for (int i = currentPieces; i > newPieces; --i) 
            {
               Destroy(puzzleCanvas.transform.GetChild(i-1).gameObject);
                
            }
        }

        if (currentPieces < newPieces)
        {
            for (int i = currentPieces; i < newPieces; i++)
                AddPuzzleSprite(i);
        }
    }

    private void AddPuzzleSprite(int pieceIndex)
    {
        GameObject image = new GameObject();
        image.transform.parent = puzzleCanvas.transform;
        image.AddComponent<Image>().sprite = puzzleTexture;
        image.transform.localScale = new Vector2(0.2f, 0.2f);
        image.GetComponent<Image>().gameObject.transform.position = new Vector2(128 + pieceIndex * 128, 32);
    }

    
}
