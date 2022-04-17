using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Vector3 respawnPoint;
    private int P1Score;
    private int P2Score;

    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        P1Score = 0;
        P2Score = 0;

        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespawnPlayer()
    {
        Debug.Log("Player Respawn");
        transform.position = respawnPoint;
    }
}
