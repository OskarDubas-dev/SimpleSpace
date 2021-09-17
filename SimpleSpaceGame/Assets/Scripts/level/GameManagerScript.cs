using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    int score = 0;
  
    void Awake()
    {
        setUpSingleton();
    }

    private void setUpSingleton()
    {
        if(FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void resetGame()
    {
        Destroy(gameObject);
    }


    public int getScore()
    {
        return score;
    }

    public void addToScore(int scoreValue)
    {
        score += scoreValue;
    }

}
