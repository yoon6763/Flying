using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCloud : MonoBehaviour
{
    public float deletTime = 7.0f;
    GameObject cloudObj;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(cloudObj, deletTime);
    }

    // Update is called once per frame
    void Update()
    {
  
    }
}
