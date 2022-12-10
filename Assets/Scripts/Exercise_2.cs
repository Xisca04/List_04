using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_2 : MonoBehaviour
{
    // Centimetres to inches

    public float number;

    private float Calculator(float number)
    {
        float result = number * 0.39f;
        return result;
        Debug.Log($"{number} cm is equal to {result} inches.");
    }

    private void Start()
    {
        Calculator(number);
    }
}
