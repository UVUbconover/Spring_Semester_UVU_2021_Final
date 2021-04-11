using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private float startDelay = 1f;
    private float spawnInterval;
    private float spawnPosX = -435.22f;
    private float spawnPosY = -10.99999f;
    private float spawnPosZ = 0.54f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar", startDelay, spawnInterval = Random.Range(3, 12));
    }


    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomCar()
    {
        // Generate random ball index and random spawn position
        int index = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);

        // instantiate ball at random spawn location
        Instantiate(carPrefabs[index], spawnPos, carPrefabs[index].transform.rotation);

    }
}
