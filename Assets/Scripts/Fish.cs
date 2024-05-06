using System.Collections;
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

    public AudioSource audioSource;
    public AudioClip clip;

    void Start()
    {
        
    }

    void Update()
    {
        if (pickupAllowed && Input.GetKeyDown(KeyCode.Space) && !onDeathRow)
        {
            audioSource.PlayOneShot(clip, 0.5f);
            pickUp();
        }

        if ((myManager.bubCount == bubbleDeathAmount) & (onDeathRow)) {
            if (fishType == "Big")
            {
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

        if (!myManager.fishSentencing && onDeathRow) {
            Destroy(gameObject);
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
        myManager.maxBubbles = 3;
        myManager.shrinkDuration = 4;
        myManager.fishSentencing = true;

        spawnBubble();
        onDeathRow = true;
    }
}
