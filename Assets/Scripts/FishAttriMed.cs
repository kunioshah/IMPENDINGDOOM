using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAttriMed : MonoBehaviour
{
    public GameObject medFish;
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
        if (medFish)
        {
            float selfValue = Random.Range(fishValue[3], fishValue[6]);
        }
    }
}
