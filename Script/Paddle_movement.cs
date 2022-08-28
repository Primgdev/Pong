using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paddle_movement : MonoBehaviour
{
    Rigidbody2D rb2d;
    public KeyCode upward;
    public KeyCode downward;
    public AudioSource hit;


    // Start is called before the first frame update
    void Start()
    {
      rb2d = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(upward)) //input for the up movement
        {
            rb2d.velocity = new Vector2(-2f, 6f);  
        }
        else if (Input.GetKey(downward)) //input for down movement
        {
            rb2d.velocity = new Vector2(2f, -6f);
        }

       

    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "ball") //execute code if object hit to the object with the tag "ball"
        {
            hit.Play(); //play sound
        }
    }
}
