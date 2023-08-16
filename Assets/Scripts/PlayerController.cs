using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1;
    public float jumpSpeed = 1;
    private string test = "Bonjour.";
    bool isGrounded = true;

    public Collider2D GroundCollider;
    Collider2D playerCollider;
    Rigidbody2D playerRB;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(test);
        playerCollider = GetComponent<Collider2D>();
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCollider.IsTouching(GroundCollider))
            isGrounded = true;
        else
            isGrounded = false;

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * moveSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            //transform.position += Vector3.up * jumpSpeed;

            playerRB.AddForce(Vector2.up * jumpSpeed);
        }
    }
}
