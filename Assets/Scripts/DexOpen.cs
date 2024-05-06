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
    //void Update()
    //{
    //    dexButton.onClick.AddListener(taskOnClick);
    //}

    //private void taskOnClick ()
    //{
    //    print("clicked");
    //    if (isDexOpen == false)
    //    {
    //        dexCanvas.SetActive(true);
    //        isDexOpen = true;
    //        print("dex is open");
    //    }
    //    else
    //    {
    //        dexCanvas.SetActive(false);
    //        isDexOpen = false;
    //        print("dex is closed");
    //    }
    //}
    public void setDexActive() {
        dexCanvas.SetActive(true);
    }

    public void setDexClosed()
    {
        dexCanvas.SetActive(false);
    }


}
