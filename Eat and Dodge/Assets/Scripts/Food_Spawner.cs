using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Spawner : MonoBehaviour
{
    public GameObject[] gamePrefabs;
    private float xRange = 10.68f, yPos = 0.5f, zPos = -6f;
    private float startDelay = 1f;
    private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFood", startDelay, spawnInterval);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnFood()
    {
        //Randomly spawns food for dog to eat within the camera frame.
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), yPos, zPos);
        int foodIndex = Random.Range(0, gamePrefabs.Length);
        Instantiate(gamePrefabs[foodIndex], spawnPos, gamePrefabs[foodIndex].transform.rotation);
    }

}

