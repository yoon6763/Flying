using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    public int speed = -12; //스피드 
    public float interval = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(
                GetComponent<Rigidbody2D>().velocity.x + speed, 0);
        //InvokeRepeating("Move", 0.1f,interval);
    }
    void Move()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(
                GetComponent<Rigidbody2D>().velocity.x+speed, 0);
    }
}
