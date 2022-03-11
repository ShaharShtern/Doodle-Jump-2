using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCoinsScript : MonoBehaviour
{
    public Text coinText;
    public PlayerStats playerStats;
    void Start()
    {

    }
    void Update()
    {
        coinText.text = playerStats.coins.ToString();
    }
}
