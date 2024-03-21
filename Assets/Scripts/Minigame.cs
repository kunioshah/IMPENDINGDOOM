using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame : MonoBehaviour
{
    public float BubbleTimerNow;
    public float BubbleTimerMax;
    public bool MinigameMode = false;
    public GameObject Bubble;

    private void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (MinigameMode == true)
        {
            if (BubbleTimerNow <= 0)
            {
                Debug.Log("Bubblespawned");
                Bubblespawn();
                BubbleTimerNow = BubbleTimerMax;
            }
            else
            {
                BubbleTimerNow -= Time.deltaTime;
            }

        }
    }

    void Bubblespawn()
    {
        Instantiate (Bubble, Vector3.zero, Quaternion.identity);
        Debug.Log("instantiate");
        if (Bubble.transform.localScale == new Vector3(5,5,0))
        {
            Destroy(gameObject);
            Debug.Log("destroyed");
        }
        else
        {
        Bubble.transform.localScale = transform.localScale + new Vector3(0.001f, 0.001f, 0);
        Debug.Log("bubble getting bigger");
        }
    }
    

}
