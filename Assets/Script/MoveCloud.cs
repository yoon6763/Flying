using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    int speed;
    public float interval = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(2, 17);
        speed = -speed;
        InvokeRepeating("Move", 0.1f, interval);
    }

    // Update is called once per frame
    void Move()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(
            GetComponent<Rigidbody2D>().velocity.x + speed, 0);
    }
}
