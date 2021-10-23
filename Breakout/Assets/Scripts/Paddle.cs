using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private float screenWidthInUnits;
    private const float paddleHalfWidth = 1f;

    void Start()
    {
        screenWidthInUnits = Camera.main.aspect * Camera.main.orthographicSize * 2;
    }

    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        var paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, paddleHalfWidth, screenWidthInUnits - paddleHalfWidth);
        transform.position = paddlePos;
    }
}
