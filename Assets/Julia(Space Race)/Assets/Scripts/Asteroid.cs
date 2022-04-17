using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    private float _AsteroidSpeed1 = 5f;
  /*  private float _AsteroidSpeed2 = 3f;
    private float _AsteroidSpeed3 = 2f;*/
    
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        // Assigns the RigidBody2D to container
        rb2D = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb2D.velocity = new Vector2(_AsteroidSpeed1 * transform.localScale.x, 0);
        
    }

}
