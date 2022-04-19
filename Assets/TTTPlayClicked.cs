using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TTTPlayClicked : MonoBehaviour
{
    public void LoadTTT()
    {
        SceneManager.LoadScene("TTT");
    }
}
