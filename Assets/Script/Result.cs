using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Result : MonoBehaviour
{
    public GameObject resultUI;
    public GameObject retrybutton;
    public TextMeshProUGUI rankingText;
    public GameObject player;
    public Rigidbody2D rigid;
    public bool two = false;

    // Start is called before the first frame update
    void Start()
    {
        retrybutton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControl.isOver)
        {
            resultUI.SetActive(true);
            setRanking();
        }
        else
        {
            resultUI.SetActive(false);
            rankingText.text = "";
        }
    }
    public void onRetry()
    {
        rigid.velocity = new Vector2(0, 0);
        rigid.position = new Vector2(-8, 4);
        ScoreText.time = 0;
        ScoreText.score = 0;
        PlayerControl.isOver = false;
        PlayerControl.nowTime = 0;
    }

    public void setRanking()
    {
        RankingSave rs = new RankingSave();
        int[] intScore = rs.rankImport();
        string text = "Ranking\n\n";

        for (int i = 0; i < intScore.Length; i++)
        {
            if (i == 0)
            {
                text = text + (i + 1) + "st  " + intScore[i] + "\n";
            }
            else if (i == 1)
            {
                text = text + (i + 1) +"nd  "+intScore[i] + "\n";
            }
            else if( i == 2)
            {
                text = text + (i + 1) + "rd  " + intScore[i] + "\n";
            }
            else
            {
                text = text + (i + 1) + "th  " + intScore[i] + "\n";
            }
        }
        
        rankingText.text = text;
    }
}
