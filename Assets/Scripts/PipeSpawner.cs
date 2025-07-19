using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [SerializeField] private GameObject pipePrefab;
    private float spawnTimerMax = 2f;
    private float spawnTimer = 0f;

    private void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnTimerMax)
        {
            SpawnPipe();
            spawnTimer = 0f;
        }
    }

    private void SpawnPipe()
    {
        float randomY = Random.Range(-2f, 2f);
        Vector3 spawnPosition = new(11f, randomY, 0f);
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }

}
