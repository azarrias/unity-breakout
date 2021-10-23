using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private float screenWidthInUnits;

    void Start()
    {
        screenWidthInUnits = Camera.main.aspect * Camera.main.orthographicSize * 2;
    }

    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        var paddlePos = new Vector2(mousePosInUnits, transform.position.y);
        transform.position = paddlePos;
    }
}
