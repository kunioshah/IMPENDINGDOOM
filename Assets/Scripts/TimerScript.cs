using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{

    public Image timerBar;
    public float time = 5f;
    float timeLeft;
    
    // Start is called before the first frame update
    void Start()
    {
        //timerBar = GetComponent<Image> ();
        timeLeft = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0) {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = Mathf.Clamp01(timeLeft / time);
        }
        else {
            SceneManager.LoadScene(2);
        }
    }
}
