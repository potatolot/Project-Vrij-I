using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPuzzelHandler : MonoBehaviour
{
    // Amount of puzzle player 
    private int PiecesHolding = 0;

    public int CheckPieces() { return PiecesHolding; }

    public void AddPiece() { PiecesHolding++; }

    public void SetPieces(int amount) { PiecesHolding = amount;  }

    public void Update()
    {
        print(PiecesHolding);
    }
}
