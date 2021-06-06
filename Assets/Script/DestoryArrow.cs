using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryArrow : MonoBehaviour
{
    public float deletTime = 5.0f;
    GameObject obj;
    void Start()
    {
        Destroy(gameObject, deletTime);
    }
    // Update is called once per frame
    void Update()
    {
        if (PlayerControl.isOver)
        {
            Destroy(gameObject, 0);
        }
    }

}
