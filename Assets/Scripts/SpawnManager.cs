using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawn;
    public GameObject firstPosOb;
    public GameObject lastPosOb;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    [SerializeField] private float startDelay = 2;
    private float maxRepetDelay = 5;
    private float minRepetDelay = 2;
    [Range(1, 5)]
    [SerializeField] private float repeatDelay = 2;
    private PlayerController playerControllerScript;
    [Range (1,1.4f)]
    [SerializeField] private float ObstacleHight = 1;
    private float minHight = 1;
    private float maxHight = 1.4f;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
    }


    void SpawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            Instantiate(spawn, spawnPos, spawn.transform.rotation);
            ObstacleHight = Random.Range(minHight, maxHight);
            Transform trans = spawn.transform;
            spawn.transform.localScale = new Vector3(trans.localScale.x, ObstacleHight, trans.localScale.z);
            repeatDelay = Random.Range(minRepetDelay, maxRepetDelay);
            spawnPos = new Vector3(Random.Range(firstPosOb.transform.position.x, lastPosOb.transform.position.x), spawnPos.y, spawnPos.z);
        }
    }
}