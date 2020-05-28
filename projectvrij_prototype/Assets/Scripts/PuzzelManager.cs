using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PuzzelManager : MonoBehaviour
{
    // list with puzzleparts
    [SerializeField] private List<PuzzelPiece> puzzelParts = new List<PuzzelPiece>();

    // When the manager get a trigger
    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            for (int i = 0; i < puzzelParts.Count; i++)
            {
                //Checks whether the puzzle piece is not yet visible
                if (!puzzelParts[i].isVisible)
                {
                    //Makes the puzzle piece visible
                    puzzelParts[i].SetVisible();
                    break;
                }
            }
        }

    }
}
