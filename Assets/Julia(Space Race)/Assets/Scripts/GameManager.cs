using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Game Management
    public GameOverScreen GameOverScreen;
    public bool isGameOver = false;
    
    public void GameOver()
    {
        isGameOver = true;
        GameOverScreen.Setup();
        Debug.Log("Game Over!");
    }

    // Respawn
    public static GameManager instance;

    public Transform respawnPointP1;
    public Transform respawnPointP2;
    
    public GameObject leftRocketPrefab;
    public GameObject rightRocketPrefab;
    


    private void Awake()
    {
        instance = this;
    }

    public void RespawnPlayer1()
    {
        Instantiate(leftRocketPrefab, respawnPointP1.position, Quaternion.identity);   
        
        Debug.Log("Player1 Respawn");
    }
    public void RespawnPlayer2()
    {
        Instantiate(rightRocketPrefab, respawnPointP2.position, Quaternion.identity);

        Debug.Log("Player2 Respawn");
    }


}
