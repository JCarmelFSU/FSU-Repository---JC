using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnRangeX = 19;
    private float spawnPosZ = 15;
    private float lowerYBound = 0.9f;
    private float upperYBound = 2.5f;
    private float startDelay = 2;
    private float spawnRate = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(lowerYBound, upperYBound), spawnPosZ);
        
        Instantiate(enemyPrefabs[0], spawnPos, enemyPrefabs[0].transform.rotation);
    }
}
