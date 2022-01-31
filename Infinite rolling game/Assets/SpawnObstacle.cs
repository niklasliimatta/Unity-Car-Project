using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    [Header("Spawning Speed")]
    public float spawnSpeed;

    
    public GameObject[] spawners;
    float spawnTimer = 0;
    void Start()
    {
        spawnTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(spawnTimer >= spawnSpeed)
        {    
            Spawn();
            spawnTimer = 0;     
            
        }
        
        spawnTimer += Time.deltaTime;
        
    }

    void Spawn()
    { 
    
        var randomSpawn = Random.Range(0,spawners.Length);
        Instantiate(spawners[randomSpawn]);
        
       
            
            
            
        
        
        
    }
}


