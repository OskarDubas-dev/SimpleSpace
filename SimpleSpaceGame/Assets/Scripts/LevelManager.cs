using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private float screenDelay = 2.1f;
    [SerializeField] private GameObject playerPrefab;

    void Awake()
    {
        setUpSingleton();
    }

    public void loadStartMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void loadGame(string levelname)
    {
        SceneManager.LoadScene(levelname);
        loadPlayer();

    }

    public void loadGameWithDelay(string levelname)
    {
        StartCoroutine(delayScreenLoad(levelname, true));
    }



    public void deathScreen()
    {
        StartCoroutine(delayScreenLoad("DeathScreen", false));
      
    }

    public void gameOverScreen()
    {
        StartCoroutine(delayScreenLoad("GameOver", false));
       
        
       
    }

    public void quitGame()
    {
        Application.Quit();
    }


    IEnumerator delayScreenLoad(string levelname, bool loadplayer)
    {
        yield return new WaitForSeconds(screenDelay);
        SceneManager.LoadScene(levelname);
        
        if(loadplayer)
        loadPlayer();
    }

    private void loadPlayer()
    {
        GameObject player = Instantiate(playerPrefab, transform.position, transform.rotation) as GameObject;
    }

    private void setUpSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }


}
