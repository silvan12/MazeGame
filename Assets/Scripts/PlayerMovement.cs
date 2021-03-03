using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float moveSpeed;
    public float rotationSpeed;
    void FixedUpdate()
    {
        
        // Adds relative Y force to player
        float moveY = Input.GetAxis("Vertical");
        Vector2 playerPosition = new Vector2(0, moveY);
        rb2D.AddRelativeForce(playerPosition * moveSpeed);
        
        // Rotation
        float rotateZ = Input.GetAxis("Horizontal");
        transform.Rotate(0,0, rotateZ * rotationSpeed, Space.Self);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
