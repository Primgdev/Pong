using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    Rigidbody2D ai;
    public Transform ball;
    float speed = 5.0f;
    public AudioSource hit;


    void Start()
    {
        ai = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float d = Mathf.Abs(ball.position.y - transform.position.y);
        if (d > 3) //if distance is greater than 3
        {
            if(ball.position.y > transform.position.y) 
            {
                ai.velocity = new Vector2(0f, 1f) * speed; 
            }
        
            if (ball.position.y < transform.position.y)
            {
                ai.velocity = new Vector2(0f, -1f) * speed;
            }
        }
       
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ball")
        {
            hit.Play(); //play sound
        }
    }

}
