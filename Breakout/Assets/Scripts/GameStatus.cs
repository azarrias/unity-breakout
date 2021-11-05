using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    [Range(0.1f, 10f)]
    [SerializeField] private float timeScale = 1f;

    void Start()
    {
        Time.timeScale = timeScale;
    }

    void Update()
    {
 
    }
}
