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
    public int currentScore;

    public void attributePicker(int number)
    {
        print("attribut pickin");
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
        Totalmoney = 0;
        
        foreach (int fish in fishList)
        {
            print("this fish costs " + fish);
            Totalmoney = Totalmoney + fish;
        }
        print("total money is " + Totalmoney);

        if (Totalmoney > currentScore)
        {
            currentScore = Totalmoney;
        }
    }

    public void clearList() {
        fishList.Clear();
    }

}
