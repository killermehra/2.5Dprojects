using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    public GameObject[] prefabToSpawn;
    public float T1, T2;

    private void Start()
    {
        float spawnInterval = Random.Range(T1, T2);


        InvokeRepeating("SpawnObject", 0f, spawnInterval);

    }

    private void SpawnObject()
    {
        int spawn = Random.Range(0, prefabToSpawn.Length);
        Instantiate(prefabToSpawn[0], transform.position, Quaternion.identity);
    }
}