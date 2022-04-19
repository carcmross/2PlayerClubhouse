using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartScreen : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    public void PlayGame()
    {
        gameObject.SetActive(false);
        GameManager.instance.GameStart();
    }
    
}
