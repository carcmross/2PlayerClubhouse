using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    float currentTime = 0;
    public float startingTime = 60;

    public TextMeshProUGUI countdownText;



    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
       
        if (currentTime < 10)
        {
                countdownText.color = Color.red;
        } 

        if (currentTime <= 0)
        {
            currentTime = 0;
            GameManager.instance.GameOver();
        }

    }
}
