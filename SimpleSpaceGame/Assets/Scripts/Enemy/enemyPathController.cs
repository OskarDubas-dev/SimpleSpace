using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        //foreach(var path in pathList)
        //{
        //    Debug.Log(path.name);

          
        //}

        

    }





}
