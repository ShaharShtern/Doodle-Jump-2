using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector3 spawnPosition;
    public GameObject metalPlatform;
    public Transform playerTransform;
    public GameObject[] midgamePlatforms;
    public GameObject[] endgamePlatforms;
    public float platRangeX; 
    public float platRangeYmin;
    public float platRangeYmax;
    public float coinRangeYmin;
    public float coinRangeYmax;
    public GameObject coin;
    public Vector3 coinSpawnPosition;
    public Vector3 spikeSpawnPosition;
    public GameObject spike;
   
    void Start()
    {
        //create starting platforms
        for (int i = 0; i < 5; i++)
        {
            CreatPlatformsStart();
        }
        for (int i = 0; i < 5; i++)
        {
            CreatePlatformMidgame();
        }
    }

    void Update()
    {
        //create endgame platforms and objects as the player climbs
        if (playerTransform.position.y>spawnPosition.y -15)
        {
            CreatePlatformsEndgame();
            
            
        }
        if (playerTransform.position.y>coinSpawnPosition.y -15)
        { 
            CreateCoins();
        }
        if (spawnPosition.y>40&&playerTransform.position.y> spikeSpawnPosition.y -15)
        {
                CreateSpike();
        }
    }
    void CreatPlatformsStart()
    {
        float randX = Random.Range(-platRangeX, platRangeX);
        float randY = Random.Range(platRangeYmin, platRangeYmax);
        spawnPosition.x = randX;
        spawnPosition.y += randY;
        Instantiate(metalPlatform, spawnPosition, Quaternion.identity);
    }
    void CreatePlatformMidgame()
    {
        float randX = Random.Range(-platRangeX, platRangeX);
        float randY = Random.Range(platRangeYmin, platRangeYmax);
        spawnPosition.x = randX;
        spawnPosition.y += randY;
        int randomIndex = Random.Range(0, midgamePlatforms.Length);
        Instantiate(midgamePlatforms[randomIndex], spawnPosition, Quaternion.identity);
    }
    void CreatePlatformsEndgame()
    {
        float randX = Random.Range(-platRangeX, platRangeX);
        float randY = Random.Range(platRangeYmin, platRangeYmax);
        spawnPosition.x = randX;
        spawnPosition.y += randY;
        int randomIndex = Random.Range(0, endgamePlatforms.Length);
        Instantiate(endgamePlatforms[randomIndex], spawnPosition, Quaternion.identity);
    }
    void CreateCoins()
    {
        float randX = Random.Range(-platRangeX*0.8f, platRangeX*0.8f);
        float randY = Random.Range(coinRangeYmin, coinRangeYmax);
        coinSpawnPosition.x = randX;
        coinSpawnPosition.y += randY;
        Instantiate(coin, coinSpawnPosition, Quaternion.identity);
    }
    void CreateSpike()
    {
        float randX = Random.Range(-platRangeX*0.8f, platRangeX*0.8f);
        float randY = Random.Range(coinRangeYmin, coinRangeYmax);
        spikeSpawnPosition.x = randX;
        spikeSpawnPosition.y += randY;
        Instantiate(spike, spikeSpawnPosition, Quaternion.identity);
    }
}
