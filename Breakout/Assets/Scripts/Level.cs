using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // Serialized only for debugging purposes
    [SerializeField] private int breakableBlocks; 

    public void IncreaseNumberOfBreakableBlocks()
    {
        breakableBlocks++;
    }
}
