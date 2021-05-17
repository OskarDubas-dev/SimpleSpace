using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] List<waveConfiguration> waveConfigs;
    int startingWave = 0;
    private void Start()
    {
        var currentWave = waveConfigs[startingWave];
        StartCoroutine(spawnAllEnemiesInWave(currentWave));
    }

    private IEnumerator spawnAllEnemiesInWave(waveConfiguration waveConfig) //set waveConfig to enemy and start spawning them
    {
        int counter = 0;
        while (counter != waveConfig.numberOfEnemies)
        {
            GameObject enemy = Instantiate(waveConfig.enemyPrefab, waveConfig.GetWaypoints()[0].transform.position, Quaternion.identity) as GameObject;
            enemy.GetComponent<enemyPathing>().setWaveConfig(waveConfig);
            yield return new WaitForSeconds(waveConfig.timeBetweenSpawns);
            counter++;
        }
    }
}
