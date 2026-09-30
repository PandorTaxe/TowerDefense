using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject zoneToSpawn;
    [SerializeField] private float spawnCooldown;
    //rajouter
    private Dictionary<Enemy, int> enemyCount;
    [SerializeField] List<EnemyData> Enemies;
    [Serializable]
    public struct EnemyData
    {
        public Enemy enemy; 
        public int Value;
    }
    //rajouter
    
    private void Start()
    {
        enemyCount = new();
        foreach (var tiki in Enemies) {
            enemyCount.Add(tiki.enemy,  tiki.Value);
        }
        
        SpawnWave();
    }

    void SpawnEnemy(Enemy enemy)
    {
        Instantiate(enemy, zoneToSpawn.transform.position, Quaternion.identity);
    }

    void SpawnWave()
    {
        foreach (var enemy in enemyCount)
        {
            for (int i = 0; i < enemy.Value; i++)
            {
                SpawnEnemy(enemy.Key);
            }
        }
    }
}
