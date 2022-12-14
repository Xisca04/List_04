using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_4 : MonoBehaviour
{
    // Random element - Array

    public string[] element;
    private int stringIndex;

    private void SpawnRandomAnimal()
    {
        stringIndex = Random.Range(0, element.Length);
        //Instantiate(element[stringIndex], new Vector3(0, 0, 2), Quaternion.identity);

    }

    private void Start()
    {
        SpawnRandomAnimal();
    }

}
