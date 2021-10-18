using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject powerUpPrefab;
    public GameObject enemyPrefab;
    private float spawnRange = 9;
    private int enemyCount;
    private int enemyWave = 1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(enemyWave);
        Instantiate(powerUpPrefab, GenerateRandomPos(), powerUpPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount <=0)
        {
            enemyWave++;
            SpawnEnemyWave(enemyWave);
            Instantiate(powerUpPrefab, GenerateRandomPos(), powerUpPrefab.transform.rotation);
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i= 0; i<enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateRandomPos(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateRandomPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 enemySpawnPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return enemySpawnPos;
    }
}
