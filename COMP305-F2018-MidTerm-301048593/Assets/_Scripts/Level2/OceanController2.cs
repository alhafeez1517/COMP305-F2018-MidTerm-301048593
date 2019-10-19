//Source File Name:OceanController2.cs
//Authors Name:Al Hafeez
//StudentID:301048593
//Program Description:Program for side scrolling the ocean in Level 2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanController2 : MonoBehaviour
{
    public float horizontalSpeed = 0.1f;
    public float resetPosition = 2.24f;
    public float resetPoint = -2.18f;

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }

    /// <summary>
    /// This method moves the ocean down the screen by verticalSpeed
    /// </summary>
    void Move()
    {
        Vector2 newPosition = new Vector2(horizontalSpeed,0.0f);
        Vector2 currentPosition = transform.position;

        currentPosition -= newPosition;
        transform.position = currentPosition;
    }

    /// <summary>
    /// This method resets the ocean to the resetPosition
    /// </summary>
    void Reset()
    {
        transform.position = new Vector2(resetPosition,0.0f);
    }

    /// <summary>
    /// This method checks if the ocean reaches the lower boundary
    /// and then it Resets it
    /// </summary>
    void CheckBounds()
    {
        if (transform.position.x <= resetPoint)
        {
            Reset();
        }
    }
}
