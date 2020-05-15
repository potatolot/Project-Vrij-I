using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items
{
   public enum ItemType
    {
        Eggs, 
        Pan, 
        Butter,
        Sphere, 
        Clothes
    }

    public ItemType itemType;
    public int amount; 
}
