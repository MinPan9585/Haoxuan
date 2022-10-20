using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnCooldown = 2;

    void Update()
    {
        spawnCooldown -= Time.deltaTime;
        if (spawnCooldown <= 0)
        {

            GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);


            spawnCooldown = Random.Range(2f, 4f);
        }

    }
}
