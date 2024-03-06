﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject SmolGameObject;
    public GameObject MedGameObject;
    public GameObject BeegGameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnDem()
    {
        GameObject[] fishSize = new GameObject[]{ SmolGameObject, SmolGameObject, SmolGameObject, SmolGameObject, 
            SmolGameObject, MedGameObject, MedGameObject, MedGameObject, BeegGameObject, BeegGameObject};
        Vector3 randoSpawn = new Vector3(Random.Range(-103, 106), Random.Range(49, -49), 0);

        int chosenOne = Random.Range(0, fishSize.Length);

        Instantiate(fishSize[chosenOne], randoSpawn, Quaternion.identity);
        Debug.Log(chosenOne);
    }
}