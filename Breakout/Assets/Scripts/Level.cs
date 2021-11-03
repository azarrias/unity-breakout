using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // Serialized only for debugging purposes
    [SerializeField] private int breakableBlocks;
    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void IncreaseNumberOfBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void DecreaseNumberOfBreakableBlocks()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
