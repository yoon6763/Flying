using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using System;

public class RankingSave : MonoBehaviour
{
    public RankingSave()
    {
        StreamWriter sw = new StreamWriter("Ranking.txt", true);
        sw.Close();
    }
    public void rankingSave()
    {
        StreamWriter sw = new StreamWriter("Ranking.txt", true);
        int score = ScoreText.score;

        sw.WriteLine(score);
        sw.Close();
    }

    public int[] rankImport()
    {
        StreamReader sr = new StreamReader("Ranking.txt", true);
        string temp = "";
        string str = "";

        while( (temp = sr.ReadLine()) != null)
        {
            str = str + temp + "\n";
        }
        sr.Close();

        if(str == null) // 파일 읽었는데 아무것도 없을경우
        {
            int[] returnvalue = new int[0];
            returnvalue[0] = 0;
            return returnvalue;
        }

        string[] strs = str.Split('\n');

        int[] intScore = new int[strs.Length - 1];
        for (int i = 0; i < intScore.Length; i++)
        {
            intScore[i] = int.Parse(strs[i]);
        }
        Array.Sort(intScore);
        Array.Reverse(intScore);
    
        if (intScore.Length > 10)
        {
            int[] tempint = new int[10];

            for (int i = 0; i<10; i++)
            {
                tempint[i] = intScore[i];
            }

            return tempint;
        }


        return intScore;
    }
}
