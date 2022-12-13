using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_2 : MonoBehaviour
{
    // Centimetres to inches

    public float number;
    private float result;
    
    private float Calculator(float number)
    {
        result = number * 0.39f;
        Debug.Log($"{number} cm is equal to {result} inches.");
        return result; 

    }

    private void Start()
    {
        Calculator(number);
    }
}
