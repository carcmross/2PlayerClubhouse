using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurns : MonoBehaviour
{

    public GameObject p1cont;
    public GameObject p2cont;
    public GameObject p1Waiting;
    public GameObject p2Waiting;
    public GameObject playAgain;
    public GameObject mainMenu;
    public Text scoreboardLeft;
    public Text scoreboardRight;
    public Text winnerExplanation;
    public Text winnerName;
    public bool p1Selected;
    public bool p2Selected;
    public bool gettingResults;
    public int p1Score = 0;
    public int p2Score = 0;
    public string p1Weapon;
    public string p2Weapon;

    // Start is called before the first frame update
    void Start()
    {
        p1cont = GameObject.Find("Player1Controls");
        p2cont = GameObject.Find("Player2Controls");
        p1Waiting = GameObject.Find("P1Waiting");
        p2Waiting = GameObject.Find("P2Waiting");
        scoreboardLeft = GameObject.Find("P1Score").GetComponent<Text>();
        scoreboardRight = GameObject.Find("P2Score").GetComponent<Text>();
        winnerExplanation = GameObject.Find("WinnerExplanation").GetComponent<Text>();
        winnerName = GameObject.Find("WinnerName").GetComponent<Text>();
        playAgain = GameObject.Find("PLAY AGAIN");
        mainMenu = GameObject.Find("MAIN MENU");
        p1Selected = false;
        p2Selected = false;
        gettingResults = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Player 1 Turn
        if (p1Selected == false) {
            if (Input.GetKeyDown(KeyCode.A))
            {
                p1cont.SetActive(false);
                p1Selected = true;
                p1Weapon = "Rock";
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                p1cont.SetActive(false);
                p1Selected = true;
                p1Weapon = "Paper";
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                p1cont.SetActive(false);
                p1Selected = true;
                p1Weapon = "Scissors";
            }
        }

        // Player 2 Turn
        if (p2Selected == false) 
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                p2cont.SetActive(false);
                p2Selected = true;
                p2Weapon = "Scissors";
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                p2cont.SetActive(false);
                p2Selected = true;
                p2Weapon = "Paper";
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                p2cont.SetActive(false);
                p2Selected = true;
                p2Weapon = "Rock";
            }
        }

        // Wait for input from both players
        if (p1Selected == true && p2Selected == false && gettingResults == false)
            p1Waiting.GetComponent<Text>().enabled = true;
        else if (p1Selected == false && p2Selected == true && gettingResults == false)
            p2Waiting.GetComponent<Text>().enabled = true;
        else if (p1Selected == true && p2Selected == true)
        {
            gettingResults = true;
            p1Waiting.GetComponent<Text>().enabled = false;
            p2Waiting.GetComponent<Text>().enabled = false;

            if (p1Weapon == "Rock")
            {
                if (p2Weapon == "Rock")
                {
                    winnerExplanation.text = "DRAW";
                }
                else if (p2Weapon == "Paper")
                {
                    p2Score++;
                    scoreboardRight.text = p2Score.ToString();
                    winnerExplanation.text = "PAPER BEATS ROCK";
                    winnerName.text = "PLAYER 2 TAKES THE ROUND";
                }
                else if (p2Weapon == "Scissors")
                {
                    p1Score++;
                    scoreboardLeft.text = p1Score.ToString();
                    winnerExplanation.text = "ROCK BEATS SCISSORS";
                    winnerName.text = "PLAYER 1 TAKES THE ROUND";
                }
            }
            else if (p1Weapon == "Paper")
            {
                if (p2Weapon == "Rock")
                {
                    p1Score++;
                    scoreboardLeft.text = p1Score.ToString();
                    winnerExplanation.text = "PAPER BEATS ROCK";
                    winnerName.text = "PLAYER 1 TAKES THE ROUND";
                }
                else if (p2Weapon == "Paper")
                    winnerExplanation.text = "DRAW";
                else if (p2Weapon == "Scissors")
                {
                    p2Score++;
                    scoreboardRight.text = p2Score.ToString();
                    winnerExplanation.text = "SCISSORS BEATS PAPER";
                    winnerName.text = "PLAYER 2 TAKES THE ROUND";
                }
            }
            else if (p1Weapon == "Scissors")
            {
                if (p2Weapon == "Rock")
                {
                    p2Score++;
                    scoreboardRight.text = p2Score.ToString();
                    winnerExplanation.text = "ROCK BEATS SCISSORS";
                    winnerName.text = "PLAYER 2 TAKES THE ROUND";
                }
                else if (p2Weapon == "Paper")
                {
                    p1Score++;
                    scoreboardLeft.text = p1Score.ToString();
                    winnerExplanation.text = "SCISSORS BEATS PAPER";
                    winnerName.text = "PLAYER 1 TAKES THE ROUND";
                }
                else if (p2Weapon == "Scissors")
                    winnerExplanation.text = "DRAW";
            }

            StartCoroutine(waitSomeTime());
            p1Selected = false;
            p2Selected = false;
        }
    }

    private IEnumerator waitSomeTime()
    {
        yield return new WaitForSeconds(3);
        winnerExplanation.text = "";
        winnerName.text = "";

        if (p1Score < 2 && p2Score < 2)
        {
            p1cont.SetActive(true);
            p2cont.SetActive(true);
        }
        else if (p1Score == 2)
        {
            yield return new WaitForSeconds(0.5f);
            winnerExplanation.text = "PLAYER 1 WINS THE GAME";
            playAgain.GetComponent<Image>().enabled = true;
            playAgain.transform.GetChild(0).GetComponent<Text>().enabled = true;
            mainMenu.GetComponent<Image>().enabled = true;
            mainMenu.transform.GetChild(0).GetComponent<Text>().enabled = true;
        }
        else if (p2Score == 2)
        {
            yield return new WaitForSeconds(0.5f);
            winnerExplanation.text = "PLAYER 2 WINS THE GAME";
            playAgain.GetComponent<Image>().enabled = true;
            playAgain.transform.GetChild(0).GetComponent<Text>().enabled = true;
            mainMenu.GetComponent<Image>().enabled = true;
            mainMenu.transform.GetChild(0).GetComponent<Text>().enabled = true;
        }

        gettingResults = false;
    }
}
