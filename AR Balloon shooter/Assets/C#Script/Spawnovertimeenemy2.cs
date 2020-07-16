using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class Spawnovertimeenemy2 : MonoBehaviour
{
    
   
    public Transform spawnPoints6;
    public Transform spawnPoints7;


    
    public GameObject balloons6;
    public GameObject balloons7;




    float delayAndSpawnRate = 15;
    float timeUntilSpawnRateIncrease = 70;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObject(delayAndSpawnRate));
        
    }

    IEnumerator SpawnObject(float firstDelay)
    {
        float spawnRateCountdown = timeUntilSpawnRateIncrease;
        float spawnCountdown = firstDelay;

        while (true)
        {
            yield return null;
            spawnRateCountdown -= Time.deltaTime;
            spawnCountdown -= Time.deltaTime;

            if (spawnCountdown < 0)
            {
                spawnCountdown += delayAndSpawnRate;

                
                Instantiate(balloons6, spawnPoints6.position, Quaternion.identity);
                Instantiate(balloons7, spawnPoints7.position, Quaternion.identity);



                if (spawnRateCountdown < 0 && delayAndSpawnRate > 1)
                {
                    spawnRateCountdown += timeUntilSpawnRateIncrease;
                    delayAndSpawnRate -= 0.1f;
                }
            }
        }
    }

    public bool alive;
}




