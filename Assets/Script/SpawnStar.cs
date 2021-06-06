using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStar : MonoBehaviour
{
    public GameObject star;
    public float interval = 10f;

    void Start()
    {
        InvokeRepeating("SpawnObj", 0, interval);
    }

    // Update is called once per frame
    void SpawnObj()
    {
        if(!PlayerControl.isOver && PlayerControl.nowTime > 3)
        {
            UnityEngine.Random rd = new UnityEngine.Random();

            float y = Random.Range(-4.7f, 4.7f);
            Instantiate(star, new Vector3(transform.position.x, y, 0), transform.rotation);
        }
    }
}
