using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_3 : MonoBehaviour
{
    // Lower and upper limits

    private float spawnRangeX = 10f;
    private float spawnRangeNegativeX = -12f;
    

    private Vector3 RandomPos(float spawnRangeX, float spawnRangeNegativeX)
    {
       float randomX = Random.Range(spawnRangeX, spawnRangeNegativeX);
        return new Vector3(randomX, 0, 0);
    }

    private void Start()
    {
        transform.position = RandomPos(spawnRangeX, spawnRangeNegativeX);
    }
}
