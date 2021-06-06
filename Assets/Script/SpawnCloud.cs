using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCloud : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObj", 2, 0.5f);
    }

    // Update is called once per frame
    void SpawnObj()
    {
        int selectCloud = Random.Range(1, 4);

        float y = Random.Range(-4.7f, 4.7f);

        if (selectCloud == 1)
            Instantiate(obj1, new Vector3(transform.position.x, y, 0), transform.rotation);
        else if (selectCloud == 2)
            Instantiate(obj2, new Vector3(transform.position.x, y, 0), transform.rotation);
        else if (selectCloud == 3)
            Instantiate(obj3, new Vector3(transform.position.x, y, 0), transform.rotation);

    }
}
