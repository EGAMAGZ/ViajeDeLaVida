using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    public void StartTravel()
    {
        SceneManager.LoadScene("TravelScene");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("InstructionsScene");
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void Credits()
    {
        SceneManager.LoadScene("CreditsScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
