using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float moveSpeed;
    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 playerPosition = new Vector2(moveX * moveSpeed, moveY * moveSpeed);
        rb2D.AddForce(playerPosition);
    }
}
