using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public static float time = 0;
    public static int score = 0;
    public static int bestscore = 0;
    TextMeshProUGUI tmtext;

    // Start is called before the first frame update
    void Start()
    {
        tmtext = GetComponent<TextMeshProUGUI>();
        RankingSave rs = new RankingSave();
        int[] temp = rs.rankImport();
        bestscore = temp[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerControl.isOver)
        {
            time += Time.deltaTime * 1.0f;

            if(PlayerControl.nowTime < 3)
            {
                time = 0;
            }

            score = (int)((time * 10000) / 100 * 0.3f);

            if (bestscore < score)
            {
                bestscore = score;
            }

            tmtext.text = "BestScore : " + bestscore + "\n" + "Score : " + score;
        }
        else
        {
            tmtext.text = "";
        }
    }
}
