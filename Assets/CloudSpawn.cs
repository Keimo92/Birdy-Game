using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawn : MonoBehaviour
{
    public GameObject cloud;
    public GameObject cloud2;
    public float spawnRate; // How often c spawn
    public float cloudSpawnX; // X position where pipes spawn
    public float cloudMinY; // Minimum Y position for pipes
    public float cloudMaxY; // Maximum Y position for pipes
    public float cloudSpawn2X; // X position where pipes spawn
    public float cloudMinY2; // Minimum Y position for pipes
    public float cloudMaxY2;
    public float nextSpawnTime = 0f;
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        // Check if it's time to spawn a new pipe
        if (Time.time >= nextSpawnTime)
        {
            SpawnCloud();
            nextSpawnTime = Time.time + 1f / spawnRate;

        }


    }



    public void SpawnCloud()
    { // Calculate a random Y position for the pipe
        float randomY = Random.Range(cloudMinY, cloudMaxY);
        float random2 = Random.Range(cloudMaxY2, cloudMaxY2);

        // Instantiate the pipe prefab
        GameObject newcloud = Instantiate(cloud, new Vector3(cloudSpawnX, randomY, 0), Quaternion.identity);
        GameObject newcloud2 = Instantiate(cloud2, new Vector3(cloudSpawn2X,random2, 0), Quaternion.identity);


        Destroy(newcloud, 3f);
        Destroy(newcloud2, 6f);
    }


}

