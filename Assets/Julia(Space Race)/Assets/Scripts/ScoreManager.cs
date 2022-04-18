using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreTxtP1;
    public TextMeshProUGUI scoreTxtP2;

    int scoreValueP1 = 0;
    int scoreValueP2 = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreTxtP1.text = scoreValueP1.ToString();
        scoreTxtP2.text = scoreValueP2.ToString();
    }

    public void AddPointP1()
    {
        scoreValueP1 += 1;
        scoreTxtP1.text = scoreValueP1.ToString();
    }
    public void AddPointP2()
    {
        scoreValueP2 += 1;
        scoreTxtP2.text = scoreValueP2.ToString();
    }
}
