using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ResultText : MonoBehaviour
{
    public TextMeshProUGUI resultText;

    private void Start()
    {

    }
    private void Update()
    {
        
        if (PlayerControl.isOver)
        {
            resultText.text = "\nGame Over !\n\nBest Score : " + ScoreText.bestscore + "\nResult Score : " + ScoreText.score;
        }
    }
}
