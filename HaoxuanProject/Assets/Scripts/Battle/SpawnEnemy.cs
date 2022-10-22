using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public int spawnDir;
    public GameObject enemyPrefab;
    public float spawnCooldown = 2;
    public BattleManager battleManager;

    void Update()
    {
        spawnCooldown -= Time.deltaTime;
        if (spawnCooldown <= 0)
        {
            if (battleManager.isGameOver == false)
            {
                GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                enemy.GetComponent<Enemy>().dir = spawnDir;

                spawnCooldown = Random.Range(2f, 6f);
            }
        }

    }
}
