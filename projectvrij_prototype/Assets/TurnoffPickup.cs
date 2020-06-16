using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnoffPickup : MonoBehaviour
{
    public MSMoveObjects moveobjects;
    public bool disabledScript = true;
    // Start is called before the first frame update
    void Start()
    {
        moveobjects.enabled = false;
       
        
    }

    // Update is called once per frame
    void Update()
    {
      if(disabledScript)
        {
            moveobjects.enabled = true;
        }
    }
}
