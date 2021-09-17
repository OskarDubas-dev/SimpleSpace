using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class playerLifeController : MonoBehaviour
{
    [SerializeField] public static int playerLives = 3;
    [SerializeField] public static string currentLevelName;

    private int defaultLives = 3;

    bool playerisAlive = true;

   

    void Awake()
    {
        
       
        currentLevelName = "Level1";
    }

   void Update()
    {
        //if(GameObject.Find("Player") == null)
        //{
        //    playerisAlive = false;
        //    onPlayerDeath();
        //}

       
    }

    

   

    public void resetLife()
    {
        playerLives = defaultLives;
    }
}
