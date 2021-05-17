using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Config")]
public class waveConfiguration : ScriptableObject
{
    [field: SerializeField] public GameObject enemyPrefab { get; private set; }
    [field: SerializeField] public GameObject pathPrefab { get; private set; }
    [field: SerializeField] public float timeBetweenSpawns { get; private set; } = 0.5f;
    [field: SerializeField] public int numberOfEnemies { get; private set; } = 5;
    [field: SerializeField] public float moveSpeed { get; private set; } = 2f;

    public List<Transform> GetWaypoints()
    {
        var waypoints = new List<Transform>();
        foreach (Transform waypoint in pathPrefab.transform)
        {
            waypoints.Add(waypoint.transform);

        }

        return waypoints;
    }

}
