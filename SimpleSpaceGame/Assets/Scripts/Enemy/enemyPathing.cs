using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPathing : MonoBehaviour
{
    //[SerializeField] GameObject path;
    waveConfiguration waveConfig; //scriptable object of wave configuration 
    List<Transform> waypoints;
    float moveSpeed;
    int waypointIndex = 0;

    private void Start()
    {
        //picks all children from path prefab
        waypoints = waveConfig.GetWaypoints();
        moveSpeed = waveConfig.moveSpeed;

    }

    private void FixedUpdate()
    {
        move();

        if (transform.position == waypoints[waypoints.Count - 1].position) //if enemy is on last waypoint destroy itself
        {
            destroyItself();
        }
    }

    public void setWaveConfig(waveConfiguration waveConfig)
    {
        this.waveConfig = waveConfig;
    }

    private void move() //move enemy from 1st waypoint to the last waypoint in given path object (from wave config)
    {
       if(waypointIndex <= waypoints.Count -1)
        { 
            var targetPosition = waypoints[waypointIndex].position;
            var movementThisFrame = moveSpeed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementThisFrame);

            if(transform.position == targetPosition)
            { waypointIndex++; }


        }
     
    }

    private void destroyItself()
    {
        Destroy(gameObject);
    }



}
