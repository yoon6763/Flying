using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    public TextMeshProUGUI counttext;
    int countdown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countdown = 3 - (int)PlayerControl.nowTime;
        if (countdown > 0)
        {
            counttext.text = countdown + "";
        }
        else if(countdown == 0)
        {
            counttext.text = "Game Start !";
        }
        else
        {
            counttext.text = "";
        }
    }
}
