using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloor : MonoBehaviour
{
    public GameObject obj;
    public float interval = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObj", 0, interval);
    }

    // Update is called once per frame
    void SpawnObj()
    {
        if (!PlayerControl.isOver && PlayerControl.nowTime > 3)
        {
            //랜덤 y값 생성
            UnityEngine.Random rd = new UnityEngine.Random();

            float y = Random.Range((float)-4.7, (float)4.7);

            Instantiate(obj, new Vector3(transform.position.x, y, 0), transform.rotation);
            //Instantiate(obj, transform.position, transform.rotation);
        }
    }
}
