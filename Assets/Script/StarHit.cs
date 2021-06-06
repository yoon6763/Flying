using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            ScoreText.time += 3f;
            Destroy(gameObject);
        }
    }
}
