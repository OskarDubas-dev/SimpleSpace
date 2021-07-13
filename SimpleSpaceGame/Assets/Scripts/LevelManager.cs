using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private float screenDelay = 2.1f;
    

    public void loadStartMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void loadGame(string levelname)
    {
        SceneManager.LoadScene(levelname);
    }

    public void loadGameWithDelay(string levelname)
    {
        StartCoroutine(delayScreenLoad(levelname));
    }



    public void deathScreen()
    {
        StartCoroutine(delayScreenLoad("DeathScreen"));
      
    }

    public void gameOverScreen()
    {
        StartCoroutine(delayScreenLoad("GameOver"));
       
        
       
    }

    public void quitGame()
    {
        Application.Quit();
    }


    IEnumerator delayScreenLoad(string levelname)
    {
        yield return new WaitForSeconds(screenDelay);
        SceneManager.LoadScene(levelname);
    }

   

}
