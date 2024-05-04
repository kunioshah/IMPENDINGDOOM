using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAttriBeeg : MonoBehaviour
{
    public GameObject beegFish;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void attributePicker()
    {
        float[] fishValue = new float[] { 40, 50, 70, 10, 25, 60, 80, 50 };
        if (beegFish)
        {
            float selfValue = fishValue[7];
            Debug.Log(selfValue);
        }
    }
}
