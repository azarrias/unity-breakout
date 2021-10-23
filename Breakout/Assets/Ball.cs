using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Paddle paddle;
    private Vector2 paddleToBallDistance;

    void Start()
    {
        paddleToBallDistance = transform.position - paddle.transform.position;
    }

    void Update()
    {
        var paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePos + paddleToBallDistance;
    }
}
