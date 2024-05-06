using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Scoring : MonoBehaviour
{
    public FishAttri myInv;
    string Score;
    public TMP_Text Moneytext;

    // Start is called before the first frame update
    void Start()
    {
        myInv.CashOut();
        Score = ("$" + (myInv.Totalmoney));
        Moneytext.SetText(Score);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
