using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRocket_Controller : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private float _moveSpeed = 5f;
    private Vector3 _respawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        // Assigns the RigidBody2D to container
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        _respawnPoint = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeftRocket();

    }


    void MoveLeftRocket()
    {
       
        if (Input.GetKey(KeyCode.A))
        {
            rb2D.velocity = new Vector2(-_moveSpeed, rb2D.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb2D.velocity = new Vector2(_moveSpeed, rb2D.velocity.y);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb2D.velocity = Vector2.up * _moveSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb2D.velocity = Vector2.up * -_moveSpeed;
        }
        else
        {
            rb2D.velocity = new Vector2(0f, rb2D.velocity.y);
            rb2D.velocity = new Vector2(rb2D.velocity.x, 0f);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       /* if (collision.tag == "CollisionDetector")
        {
            transform.position = _respawnPoint;
        }*/
    }
}
