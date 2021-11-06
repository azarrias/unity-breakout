using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameStatus : PersistentSingleton<GameStatus>
{
    [Header("Config")]
    [Range(0.1f, 10f)] [SerializeField] private float timeScale = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 10;
    [SerializeField] TextMeshProUGUI scoreText;

    [Header("State")]
    [SerializeField] private int currentScore = 0;

    void Start()
    {
        Time.timeScale = timeScale;
        scoreText.text = currentScore.ToString();
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }
}
