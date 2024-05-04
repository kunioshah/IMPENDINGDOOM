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


    // Start is called before the first frame update
    void Start()
    {
        attributePicker();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void attributePicker()
    {
        int[] fishArray = new int[] { };
        if (beegFish)
        {
            int[] fishValue = new int[] { 40, 50, 70, 10, 25, 60, 80, 50 };
            int selfValue = fishValue[7];
            Debug.Log(selfValue);
        }
        if (smolFish)
        {
            int[] fishValue = new int[] { 40, 50, 70, 10, 25, 60, 80, 50 };
            int selfValue = fishValue[Random.Range(0, 2)];
            Debug.Log(selfValue);
        }
        if (medFish)
        {
            int[] fishValue = new int[] { 40, 50, 70, 10, 25, 60, 80, 50 };
            string selfValue = fishValue[Random.Range(3, 6)];
            Debug.Log(selfValue);
        }

    }
    public GameObject[] fishCaught = new GameObject[] { };

}
