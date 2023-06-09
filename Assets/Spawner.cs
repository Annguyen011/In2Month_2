using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject hexagonPrefab;
    private float nextTimeSpawn = 0f;
    private void Update()
    {
        if (Time.time >= nextTimeSpawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeSpawn = Time.time + 1f/spawnRate;
        }
    }
}
