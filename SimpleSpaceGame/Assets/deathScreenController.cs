using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class deathScreenController : MonoBehaviour
{
    TMPro.TMP_Text lifeCounter;



    private void Start()
    {

        lifeCounter = gameObject.GetComponentInChildren<TMPro.TMP_Text>();
        lifeCounter.text = playerLifeController.playerLives.ToString();
        if(playerLifeController.playerLives <= 0)
            FindObjectOfType<LevelManager>().gameOverScreen();
        if(playerLifeController.playerLives > 0)
            FindObjectOfType<LevelManager>().loadGameWithDelay(playerLifeController.currentLevelName);

    }

}
