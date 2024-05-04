﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UIElements;
using Random=UnityEngine.Random;

public class Fish : MonoBehaviour
{
    [SerializeField]
    private bool pickupAllowed;
    public GameObject Bubble;
    public int bubbleDeathAmount;
    private bool onDeathRow;
    public String fishType;
    public FishAttri myInv;

    public BubbleManager myManager;

    void Start()
    {
        
    }

    void Update()
    {
        if (pickupAllowed && Input.GetKeyDown(KeyCode.Space))
        {
            pickUp();
        }

        if ((myManager.bubCount == bubbleDeathAmount) & (onDeathRow)) {
            if (fishType == "Big")
            {
                //set thing to big, then run attribute
                myInv.attributePicker(3);
            } else if (fishType == "Medium")
            {
                myInv.attributePicker(2);
            } else if (fishType == "Small")
            {
                myInv.attributePicker(1);
            }
            Destroy(gameObject);
            onDeathRow = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        {
            pickupAllowed = true;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        {
            pickupAllowed = false;
        }
    }

    public void spawnBubble() {
        Vector2 spawnLocation = new Vector2(Random.Range(0, 700), Random.Range(0, 400));
        Instantiate(Bubble, spawnLocation, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
    }

    private void pickUp()
    {
        myManager.bubCount = 0;
        if (fishType == "Big") {
            myManager.maxBubbles = 7;
            myManager.shrinkDuration = 1;
        } else if (fishType == "Medium") {
            myManager.maxBubbles = 5;
            myManager.shrinkDuration = 3;
        } else if (fishType == "Small") {
            myManager.maxBubbles = 3;
            myManager.shrinkDuration = 5;
        }

        spawnBubble();
        onDeathRow = true;
    }
}
