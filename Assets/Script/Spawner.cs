using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        foreach (var enemy in Enemies) {
            enemyCount.Add(enemy.enemy,  enemy.Value);
        }
        
        SpawnWave();
    }

    IEnumerator SpawnEnemy()//IEnumerator et non void
    {
        foreach (var enemy in enemyCount)
        {
            for (int i = 0; i < enemy.Value; i++)
            {
                Instantiate(enemy.Key, zoneToSpawn.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnCooldown);
            }
        }

        yield return null;
    }

    void SpawnWave()
    {
        StartCoroutine(SpawnEnemy());;
    }
}
