using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DayTimer : MonoBehaviour
{
    public float totalTime = 500f; // Total time for the timer in seconds
    public float timeRemaining;
   
    void Start()
    {
        timeRemaining = totalTime;
    }

    void Update()
    {
        // Update the timer countdown
        timeRemaining -= Time.deltaTime;

        // Check if time has run out
        if (timeRemaining <= 0f)
        {
            Debug.Log("Game has ended");
            SceneManager.LoadScene("GameOver");

        }
    }
}
