using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score_point;
    public int goal = 0;
    public GameObject ball;
    public Vector2 ballPosition;
    public AudioSource score_sound;
    

 
    void OnCollisionEnter2D(Collision2D ball)
    {
        if (ball.gameObject.tag == "ball")
        {
            print("working"); //print on console
            goal++; //increase goal point + 1 each time
            score_point.text = goal.ToString(); //to print goal in score text
            Destroy(ball.gameObject); //destroy the ball on collision
            StartCoroutine("Respawn"); //respawn ball random
            score_sound.Play(); //play sound on collision
         

        }
    }

    IEnumerator Respawn()
    {
        GameObject respawn = Instantiate(ball, ballPosition, Quaternion.identity); // to instantiate the ball in random position
        yield return null;
    }


}
