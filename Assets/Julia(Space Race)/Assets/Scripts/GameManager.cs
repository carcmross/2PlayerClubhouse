using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    // Respawn
    public static GameManager instance;

    public Transform respawnPointP1;
    public Transform respawnPointP2;
    
    public GameObject leftRocketPrefab;
    public GameObject rightRocketPrefab;
    
    // Game Management
    public GameOverScreen GameOverScreen;
    public Countdown Countdown;

    public bool isGameOver = false;
    public bool isGameStart = false;
   
    public void GameOver()
    {
        isGameOver = true;
        Time.timeScale = 0f;
        GameOverScreen.Setup();
        Debug.Log("Game Over!");
    } 
    
    public void GameStart()
    {
        Countdown.Setup();
        isGameStart = true;
        Debug.Log("Game is Starting...");
    }

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
