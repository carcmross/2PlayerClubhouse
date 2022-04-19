using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rpsinput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Player 1
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Player 1 chose rock!");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Player 1 chose paper!");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Player 1 chose scissors!");
        }

        // Player 2
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            Debug.Log("Player 2 chose rock!");
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            Debug.Log("Player 2 chose paper!");
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            Debug.Log("Player 2 chose scissors!");
    }
}
