using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScoreScript : MonoBehaviour
{
    public Text scoreText;
    public PlayerStats PlayerStats;
    void Start()
    {
        
    }
    void Update()
    {
        scoreText.text = PlayerStats.score.ToString();
    }
}
