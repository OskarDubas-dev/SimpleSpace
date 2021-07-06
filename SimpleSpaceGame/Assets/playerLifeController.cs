using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[SerializeField] public class PlayerDeathEvent : UnityEvent { }



public class playerLifeController : MonoBehaviour
{
    [SerializeField] int playerLives = 3;

    bool playerisAlive = true;

    //[SerializeField] GameObject player;

    public PlayerDeathEvent playerDeathEvent;


    void Awake()
    {

    }

   void Update()
    {
        if(GameObject.Find("Player") == null)
        {
            playerisAlive = false;
            onPlayerDeath();
        }
    }

    private void onEnable()
    {
        
    }

    private void onPlayerDeath()
    {
        playerDeathEvent.Invoke();
    }
}
