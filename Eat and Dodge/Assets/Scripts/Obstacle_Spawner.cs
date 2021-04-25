using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Spawner : MonoBehaviour
{
    public GameObject[] gamePrefabs;
    private float xPos = -12f, yPos = 0.5f, zRange = 8f;
    private float startDelay = 2f;
    private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnObstacle()
    {
        //Spawns obstacles from the left side of the screen.
        Vector3 spawnPos = new Vector3(xPos, yPos, Random.Range(-zRange,zRange));
        int obstacleIndex = Random.Range(0, gamePrefabs.Length);
        Instantiate(gamePrefabs[obstacleIndex], spawnPos, gamePrefabs[obstacleIndex].transform.rotation);
    }
}
