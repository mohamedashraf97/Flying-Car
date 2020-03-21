using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    private float timer;
    private int score;
    

    Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
    }
    void Update()
    {

        timer += Time.deltaTime;

        if (timer > 1f)
        {
            if (Player.dead == false)
            {
                score += 1;
            }
              score += 0;

            //We only need to update the text if the score changed.
            scoreText.text = "Time: " + score.ToString();

            //Reset the timer to 0.
            timer = 0;

        }

    }
}
