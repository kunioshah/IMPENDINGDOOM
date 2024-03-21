using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UIElements;


public class Fish : MonoBehaviour
{
    [SerializeField]
    private bool pickupAllowed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pickupAllowed && Input.GetKeyDown(KeyCode.Space))
        {
            pickUp();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       // if (collision.gameObject.name.Equals("Collect Sphere"))
        {
            pickupAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //if (collision.gameObject.name.Equals("Collect Sphere"))
        {
            pickupAllowed = false;
        }
    }

    private void pickUp()
    {
        Destroy(gameObject);
    }
}
