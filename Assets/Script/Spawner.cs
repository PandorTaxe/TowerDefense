using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject zoneToSpawn;
    [SerializeField] private float spawnCooldown;
    [SerializeField] private Dictionary<Enemy, int> enemyCount;

    void SpawnEnemy(Enemy enemy)
    {
        
    }

    void SpawnWave()
    {
        
    }
}
