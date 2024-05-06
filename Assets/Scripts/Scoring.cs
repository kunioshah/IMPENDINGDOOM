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
    string highScore;
    int currentScore;
    public TMP_Text Moneytext;
    public TMP_Text Scoretext;

    // Start is called before the first frame update
    void Start()
    {
        myInv.CashOut();
        print(myInv.Totalmoney);

        Score = ("$" + (myInv.Totalmoney));
        highScore = ("$" + myInv.currentScore);

        Moneytext.SetText(Score);
        Scoretext.SetText(highScore);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
