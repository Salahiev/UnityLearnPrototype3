using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclesPrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2f;
    private float repeatRate = 2f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("createObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void createObstacle()
    {
        int indexObstacle = Random.Range(0, obstaclesPrefab.Length);
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclesPrefab[indexObstacle], spawnPos, obstaclesPrefab[indexObstacle].transform.rotation);
        }
    }
}
