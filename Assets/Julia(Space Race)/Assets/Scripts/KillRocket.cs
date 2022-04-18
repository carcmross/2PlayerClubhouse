using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillRocket : MonoBehaviour
{
    public static KillRocket instance;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Destroy(gameObject);
            if (gameObject.tag == "Player1")
            {
                GameManager.instance.RespawnPlayer1();
            }
            else if (gameObject.tag == "Player2")
            {
                GameManager.instance.RespawnPlayer2();
            }
        }
        
        if (collision.gameObject.CompareTag("Score"))
        {
            Destroy(gameObject);
            if (gameObject.tag == "Player1")
            {
                ScoreManager.instance.AddPointP1();
                GameManager.instance.RespawnPlayer1();
            }
            else if (gameObject.tag == "Player2")
            {
                ScoreManager.instance.AddPointP2();
                GameManager.instance.RespawnPlayer2();
            }
        }

    }

    public void endRockets ()
    { 
        if(GameManager.instance.isGameOver == true)
        {
            Destroy(gameObject);
        }
    }


}
