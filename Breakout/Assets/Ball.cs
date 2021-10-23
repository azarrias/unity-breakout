using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Paddle paddle;
    [SerializeField] private float launchVelocityX = 2f;
    [SerializeField] private float launchVelocityY = 15f;
    private Vector2 paddleToBallDistance;
    private bool hasLaunched = false;

    void Start()
    {
        paddleToBallDistance = transform.position - paddle.transform.position;
    }

    void Update()
    {
        if (!hasLaunched)
        {
            LockToPaddle();
            LaunchOnMouseClick();
        }
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasLaunched = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(launchVelocityX, launchVelocityY);
        }
    }

    private void LockToPaddle()
    {
        var paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePos + paddleToBallDistance;
    }
}
