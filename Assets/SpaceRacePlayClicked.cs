using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceRacePlayClicked : MonoBehaviour
{
    public void LoadSpaceRace()
    {
        SceneManager.LoadScene("SpaceRace");
    }
}
