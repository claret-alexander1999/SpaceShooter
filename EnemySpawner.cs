using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float min_Y = -4.32f, max_Y = 4.41f;
    public GameObject enemyPrefab;
    public float timer = 2f;

    void Start()
    {
        Invoke("SpawnEnemies", timer);

    }

    void SpawnEnemies()
    {
        float pos_Y = Random.Range(min_Y,max_Y);
        Vector3 temp = transform.position;
        temp.y = pos_Y;

        Instantiate(enemyPrefab, temp, Quaternion.identity);

        Invoke("SpawnEnemies",timer);
    }

    
}
