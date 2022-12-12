using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_5 : MonoBehaviour
{
    // The positions goes out of bounds

    private float topBound = 20f;

    private float OutOfBounds()
    {
        if (transform.position.z < topBound)
        {
            Debug.Log($"The element's position goes out of bounds");
        }
    }

    private void Start()
    {
        OutOfBounds();
    }
}