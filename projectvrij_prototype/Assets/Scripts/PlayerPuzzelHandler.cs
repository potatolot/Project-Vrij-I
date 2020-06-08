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
            int childIndex = puzzleCanvas.transform.childCount;
            foreach(Transform child in puzzleCanvas.transform)
            {
                print("this is doing it");
                if (childIndex > newPieces)
                    Destroy(child.gameObject);

                childIndex--;
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
        image.transform.localScale = new Vector2(0.1f, 0.1f);
        image.GetComponent<Image>().gameObject.transform.position = new Vector2(pieceIndex * 64, 64);
    }

    
}
