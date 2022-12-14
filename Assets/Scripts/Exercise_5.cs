using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_5 : MonoBehaviour
{
    // Position - Out of bounds

    private float limitX = 1f;
    private float limitY = 2f;
    private float limitZ = 3f;
    private new Vector3 Out;

    private bool OutOfBounds(float limitX, float limitY, float limitZ)
    {
        Out = new Vector3(limitX, limitY, limitZ);

        if (transform.position = Out)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Start()
    {
        OutOfBounds(limitX, limitY, limitZ);
    }
}   
