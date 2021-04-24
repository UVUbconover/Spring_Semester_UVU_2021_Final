using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    public GameObject[] foodPrefabs;
    private float startDelay = 1f;
    private float spawnInterval;
    private float spawnPosX = -6.82f;
    private float spawnPosY = 0f;
    private float spawnPosZ =5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomFood", startDelay, spawnInterval = Random.Range(3, 8));
    }


    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomFood()
    {
        // Generate random food from the index at the spawn position
        int index = Random.Range(0, foodPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);

        // instantiate food at random spawn location.
        Instantiate(foodPrefabs[index], spawnPos, foodPrefabs[index].transform.rotation);

    }
}
