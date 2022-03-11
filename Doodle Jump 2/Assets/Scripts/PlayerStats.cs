using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int score;
    public int coins;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //calculate score by player Y
        int checkScore = Mathf.RoundToInt(transform.position.y * 100);
        //make sure score can only go up
        if (checkScore > score)
            score = checkScore;
    }
}
