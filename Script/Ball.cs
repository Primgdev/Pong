using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb2d; //rigidbody 2d 
    public Text start;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Time.timeScale = 0; // to pause the game in starting
        Direction(); // execute the direction
        
    }

    void Update()
    {

       
        if (Input.GetKeyDown("space")) //press space to execute 
        {
            Time.timeScale = 1; //resume the game
            start.enabled = false; //disable the text 
        }

    }






    public void Direction()
    {
        int direction; //define direction as interger
        direction = Random.Range(0, 2); //random direction of the ball
        if (direction == 0) //if the direction in 0 then
        {
            rb2d.velocity = new Vector2(6f, -4f); //position of the ball movement is between x = 6 , y is -4
        }
        else
        {
            rb2d.velocity = new Vector2(-6f, 4f);//position of the ball movement is between x = -6 , y is 4
        }
    }
}
