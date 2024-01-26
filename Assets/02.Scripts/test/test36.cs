using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test36 : MonoBehaviour
{
    public string Nums = "54321";

    void Start()
    {
        int sum = 0;
        for (int i = 0; i < Nums.Length; i++)
        {
            // int nums = int.Parse(Nums[i].ToString());
            int nums = int.Parse($"{Nums[i]}");

            sum += nums;
        }
        Debug.Log(sum);
    }    
}