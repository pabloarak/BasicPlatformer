using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D playerRb;
    public float speed = 2f;
    public float jumpSpeed = 300;

    bool isGrounded = true;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        playerRb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, playerRb.velocity.y);

        if(isGrounded) {
            if(Input.GetKeyDown(KeyCode.Space)){
                playerRb.AddForce(Vector2.up * jumpSpeed);
                isGrounded = false;
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision) { // collision=todo lo que choca con nuestro pj
        if(collision.gameObject.CompareTag("Ground")) {
            isGrounded = true;
        }
    }
}
