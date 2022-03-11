using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScoreScript : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;
    public PlayerStats PlayerStats;
    void Start()
    {
        highscoreText.text = "High Score:" + PlayerPrefs.GetInt("HighScore").ToString();
    }
    void Update()
    {
        scoreText.text =PlayerStats.score.ToString();
    }
}
