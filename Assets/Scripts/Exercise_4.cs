using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_4 : MonoBehaviour
{
    // Random element - Array

    public string[] element;
    private int stringIndex;

    private string SpawnRandomAnimal()
    {
        stringIndex = Random.Range(0, element.Length);
        return element[stringIndex];

    }

    private void Start()
    {
        Debug.Log($"{SpawnRandomAnimal()}");
    }

}
