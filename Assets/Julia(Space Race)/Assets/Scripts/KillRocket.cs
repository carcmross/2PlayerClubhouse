using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillRocket : MonoBehaviour
{
    public GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            gameManager.RespawnPlayer();
        }
    }
}
