using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    public static int scoreValue = 0;
    Text score;

    public void GameOver(){
        gameOverScreen.Setup(scoreValue);
    }

    void Start()
    {
        score = GetComponent<Text>();
    }

    void Update()
    {
        score.text = "Score: " + scoreValue;
    }
}
