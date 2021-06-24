using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   

    public void loadStartMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void loadGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
