using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private float deathScreenDelay = 2.1f;

    public void loadStartMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void loadGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void deathScreen()
    {
        StartCoroutine("delayDeathScreenLoad");
      
    }

    public void gameOverScreen()
    {
        StartCoroutine("delayGameOverLoad");
       
    }

    public void quitGame()
    {
        Application.Quit();
    }


    IEnumerator delayDeathScreenLoad()
    {
        yield return new WaitForSeconds(deathScreenDelay);
        SceneManager.LoadScene("DeathScreen");
    }

    IEnumerator delayGameOverLoad()
    {
        yield return new WaitForSeconds(deathScreenDelay);
        SceneManager.LoadScene("GameOver");
    }


}
