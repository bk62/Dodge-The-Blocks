using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints = new Transform[5];
    public GameObject blockPrefab;

    public float timeBetweenWaves = 1.5f;
    private float timeToSpawn = 2f;

    void Update()
    {
        if(Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
        
    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++) {
            if (i == randomIndex) {
                continue;
            }
            Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
        }
    }

}
