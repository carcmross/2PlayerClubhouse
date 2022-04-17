using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightRocket_Controller : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private float _moveSpeed = 5f;
  
    private Vector2 _currentVelocity;


    // Start is called before the first frame update
    void Start()
    {
        // Assigns the RigidBody2D to container
        rb2D = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        MoveRightRocket();

    }

    /* void FixedUpdate()
     {
         MoveRocket();

     }*/

    void MoveRightRocket()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2D.velocity = new Vector2(-_moveSpeed, rb2D.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2D.velocity = new Vector2(_moveSpeed, rb2D.velocity.y);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb2D.velocity = Vector2.up * _moveSpeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb2D.velocity = Vector2.up * -_moveSpeed;
        }
        else
        {
            rb2D.velocity = new Vector2(0f, rb2D.velocity.y);
            rb2D.velocity = new Vector2(rb2D.velocity.x, 0f);
        }

    }
}
