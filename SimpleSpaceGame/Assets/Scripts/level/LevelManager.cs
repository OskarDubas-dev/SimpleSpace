using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private float screenDelay = 2.1f;
    [SerializeField] private GameObject playerPrefab;
    

    public void loadStartMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //public void loadGame(string levelname)
    //{
    //    SceneManager.LoadScene(levelname);
    //    loadPlayer();

    //}

    public void loadGame(string levelname)
    {
        StartCoroutine(LoadYourAsyncScene(levelname));
        

    }

    public void loadGameWithDelay(string levelname)
    {
        //TODO this is wrong, above is correct
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

    IEnumerator LoadYourAsyncScene(string levelname)
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(levelname);
        
        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            
            yield return null;
        }

        // Instantiate Player when scene is loaded
        if(asyncLoad.isDone) loadPlayer();

    }


}
