using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DexOpen : MonoBehaviour
{
    private bool isDexOpen;
    public GameObject dexCanvas;
    public Button dexButton;

    // Start is called before the first frame update
    void Start()
    {
        isDexOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        dexButton.onClick.AddListener(taskOnClick);
    }
private void taskOnClick ()
    {
        if (isDexOpen == false)
        {
            dexCanvas.SetActive(true);
            isDexOpen = true;
        }
        else
        {
            dexCanvas.SetActive(false);
            isDexOpen = false;
        }
    }
}
