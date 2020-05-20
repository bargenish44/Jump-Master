using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] public float speed = 20;
    private PlayerController playerControllerScript;
    private Transform bound;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        bound = GameObject.Find("xBound").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            GameObject.Find("Rock").transform.Rotate(0, 0, -1);
        }
        else
        {
            Destroy(GameObject.Find("Rock"));
        }
            
        if (transform.position.x < bound.position.x && gameObject.CompareTag("Obstacle"))
            Destroy(gameObject);
    }
}