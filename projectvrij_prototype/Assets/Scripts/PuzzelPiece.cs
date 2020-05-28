using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzelPiece : MonoBehaviour
{
    // Holds whether you can see the puzzelpiece
    private bool visible = false;
    [HideInInspector] public bool isVisible { get { return visible; } }


    //Makes the puzzelpiece visible
    public void SetVisible()
    {
        //Sets the puzzle piece visible
        visible = true;
        GetComponent<Renderer>().enabled = true;
    }

}
