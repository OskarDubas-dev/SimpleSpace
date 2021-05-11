using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPathing : MonoBehaviour
{
    [SerializeField] GameObject path;
    List<Transform> waypoints;
    float moveSpeed = 2.0f;
    int waypointIndex = 0;

    private void Start()
    {
        waypoints = new List<Transform>();
        foreach(Transform waypoint in path.transform)
        {
            waypoints.Add(waypoint.transform);
           
        }

        foreach(var waypoint in waypoints)
        {
            Debug.Log(waypoint.transform);
        }

        
    }

    private void FixedUpdate()
    {
        move();
    }

    private void move()
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


}
