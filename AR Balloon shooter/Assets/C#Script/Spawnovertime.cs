using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class Spawnovertime : MonoBehaviour
{
    public Transform spawnPoints1;
    public Transform spawnPoints2;
    public Transform spawnPoints3;

    public GameObject balloons1;
    public GameObject balloons2;
    public GameObject balloons3;

    float delayAndSpawnRate = 2;
    float timeUntilSpawnRateIncrease = 7;
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

                Instantiate(balloons1, spawnPoints1.position, Quaternion.identity);
                Instantiate(balloons2, spawnPoints2.position, Quaternion.identity);
                Instantiate(balloons3, spawnPoints3.position, Quaternion.identity);


                if (spawnRateCountdown < 0 && delayAndSpawnRate > 1)
                {
                    spawnRateCountdown += timeUntilSpawnRateIncrease;
                    delayAndSpawnRate -= 0.1f;
                }
            }
        }
    }
}




