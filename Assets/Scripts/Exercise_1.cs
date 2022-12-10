using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_1 : MonoBehaviour
{
    // Money box - Function

    public int total;
    public int num;
    private int result;
    

    private void MoneyBox(int num)
    {
        result = num + total;
        Debug.Log($"The total of the moneybox is {result}");
       
    }


    private void Start()
    {
        MoneyBox(num);
    }
}
