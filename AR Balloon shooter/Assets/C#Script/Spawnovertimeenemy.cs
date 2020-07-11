using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class Spawnovertimeenemy : MonoBehaviour
{
    
    public Transform spawnPoints4;
    public Transform spawnPoints5;


    public GameObject balloons4;
    public GameObject balloons5;

    


    float delayAndSpawnRate = 6;
    float timeUntilSpawnRateIncrease = 15;
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

                Instantiate(balloons4, spawnPoints4.position, Quaternion.identity);
                Instantiate(balloons5, spawnPoints5.position, Quaternion.identity);
                


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




