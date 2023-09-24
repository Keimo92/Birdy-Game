using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject tree;
    public float spawnRate; // How often pipes spawn
    public float pipeSpawnX; // X position where pipes spawn
    public float pipeMinY; // Minimum Y position for pipes
    public float pipeMaxY; // Maximum Y position for pipes

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
            SpawnTree();
            nextSpawnTime = Time.time + 1f / spawnRate;
            
        }


    }



    public void SpawnTree()
    { // Calculate a random Y position for the pipe
        float randomY = Random.Range(pipeMinY, pipeMaxY);

        // Instantiate the pipe prefab
        GameObject newPipe = Instantiate(tree, new Vector3(pipeSpawnX, randomY, 0), Quaternion.identity);

       
        Destroy(newPipe, 10f); 
    }


}
