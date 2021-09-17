using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private int score = 0;

    public int getScore()
    {
        return score;
    }

    public void addScore(int value)
    {
        score =+ value;
    }

    public void takeAwayScore(int value)
    {
        score =- value;
    }

   


}
