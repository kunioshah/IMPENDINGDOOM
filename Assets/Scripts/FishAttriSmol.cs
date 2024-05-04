using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAttriSmol : MonoBehaviour
{
    public GameObject smolFish;

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
        if (smolFish)
        {
            float selfValue = Random.Range(fishValue[0], fishValue[2]);
        }
    }
}
