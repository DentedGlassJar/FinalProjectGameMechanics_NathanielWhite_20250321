using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // The variable that stores the rigidbody of this player gameObject
    private Rigidbody2D playerRigidbody;

    private bool hasFlippedGravity;
    private bool canFlipGravity;

    public Vector2 moveDirection;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    // TODO:
    // - Have the player move left and right when the a or left arrow key, and d or right arrow key are pressed respectively
    // - When the player presses the space bar; have the gravity reverse so the player rises up, while they still have control in mid-air

    private void PlayerMovement()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (hasFlippedGravity == false)
            {
                playerRigidbody.gravityScale = -5;
                hasFlippedGravity = true;
            }
            else
            {
                playerRigidbody.gravityScale = 5;
                hasFlippedGravity = false;
            }
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection = new Vector2(-1, 0);

            playerRigidbody.velocity = new Vector2(moveDirection.x * moveSpeed * Time.deltaTime, playerRigidbody.velocity.y);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection = new Vector2(1, 0);

            playerRigidbody.velocity = new Vector2(moveDirection.x * moveSpeed * Time.deltaTime, playerRigidbody.velocity.y);
        }


    }
}
