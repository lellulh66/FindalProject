using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //info goes at the start of a class
    /*  int health = 100;
        bool isAlive = true;*/
    public float speed = 4.5f;
    public float jumpForce = 5;
    //float is used for numbers with a decimal 
    public string hero = "Oob";

    //xyz coord
    public Vector3 direction;
    public Rigidbody playerRb;


    // Start is called before the first frame update
    
    // Update is called once per frame
    //FixedUpdate is specifically best for physics loop

    void FixedUpdate()
    {
        //the dot is there to access a functionality of transform,
        // transform.Translate(direction * Time.deltaTime);
        Vector3 velocity = direction * speed;
        velocity.y = playerRb.linearVelocity.y;
        playerRb.linearVelocity = velocity;


    }

    private void OnMove(InputValue value)
    {
        // asks input what keys are being pressed
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(inputValue.x, 0, inputValue.y);

    }
    private void OnJump(InputValue value)
    {
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.6f);
        if (isGrounded) {
            playerRb.AddForce(
                Vector3.up * jumpForce, ForceMode.Impulse
            );
                };

    }

}

