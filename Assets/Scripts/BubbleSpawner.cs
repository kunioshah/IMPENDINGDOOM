using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    //  public GameObject Bubble; 

    // Start is called before the first frame update
    void Start()
    {
        SpawnBubbles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBubbles() {
        // Vector2 spawnLocation = new Vector2(Random.Range(0, 700), Random.Range(0, 400));
        // Instantiate(Bubble, spawnLocation, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
    }
}
