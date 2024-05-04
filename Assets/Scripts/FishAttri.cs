using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class FishAttri : MonoBehaviour
{
    public GameObject beegFish;
    public GameObject smolFish;
    public GameObject medFish;
    public List<int> fishList;
    public int Totalmoney;

    public void attributePicker(int number)
    {
        if (number == 3) //if the set thing is big
        {
            int[] fishValue = new int[] { 40, 50, 70, 10, 25, 60, 80, 50 };
            int selfValue = fishValue[7];
            fishList.Add(selfValue);
            Debug.Log(selfValue);
        }
        if (number ==2) //medium
        {
            int[] fishValue = new int[] { 40, 50, 70, 10, 25, 60, 80, 50 };
            int selfValue = fishValue[UnityEngine.Random.Range(3, 6)];
            fishList.Add(selfValue);
            Debug.Log(selfValue);
        }
        if (number == 1) //Small
        {
            int[] fishValue = new int[] { 40, 50, 70, 10, 25, 60, 80, 50 };
            int selfValue = fishValue[UnityEngine.Random.Range(0, 2)];
            fishList.Add(selfValue);
            Debug.Log(selfValue);
        }


    }
   
    public void CashOut()
    {
        foreach (int fish in fishList)
        {
            Totalmoney = Totalmoney + fish;
        }
        Debug.Log(Totalmoney);
    }

}
