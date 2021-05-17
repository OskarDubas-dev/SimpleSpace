using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//! Don't need this for now


//Script to manage a list of paths available for enemy ai. 
//Each path contains a list of waypoints
public class enemyPathController : MonoBehaviour
{
    List<GameObject> pathList;
    //List<GameObject> waypoints;
    void Start()
    {
        pathList = new List<GameObject>();
        foreach(Transform childPath in transform)
        {
            pathList.Add(childPath.gameObject);
        }

  

    }





}
