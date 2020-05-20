using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private float totalTime = 20;
    private float level;
    [SerializeField] private float factor = 5;
    [SerializeField] TextMeshProUGUI _Timer;
    [SerializeField] TextMeshProUGUI Level;
    private const string text = "Timer : ";
    private const string sceneGameOverName = "GameOver";
    private GameObject spawner;
    private GameObject background;
    private bool gameOver = false;
    [SerializeField]private const float MoveLeftspeed = 20;
    // Start is called before the first frame update

    void Start()
    {
        level = float.Parse(SceneManager.GetActiveScene().name);
        totalTime += (factor * level);
        Level.text += level;
        spawner = GameObject.Find("SpawnManager");
        background = GameObject.Find("Background");
        gameOver = false;
        spawner.GetComponent<SpawnManager>().spawn.GetComponent<MoveLeft>().speed = MoveLeftspeed + (level * 2);
        background.GetComponent<MoveLeft>().speed = MoveLeftspeed + (level * 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            totalTime -= Time.deltaTime;
            float RoundNum = (float)System.Math.Round(totalTime, 3);
            _Timer.text = text + RoundNum;
        }
        if (totalTime <= 0)
        {
            _Timer.text = text + 0;
            Level.text = "Level up!";
            background.GetComponent<MoveLeft>().speed = 0;
            spawner.GetComponent<SpawnManager>().spawn.GetComponent<MoveLeft>().speed = 0;
            StartCoroutine(LevelUpCoroutine());
            gameOver = true;
        }
    }



    IEnumerator LevelUpCoroutine()
    {
        yield return new WaitForSeconds(2);
        LevelUp();
    }

    public void LevelUp()
    {
        if (level < 3)
        {
            level++;
            gameObject.GetComponent<SceneCtrl>().ChangeScene("" + level);
        }
        else
        {
            gameObject.GetComponent<SceneCtrl>().ChangeScene(sceneGameOverName);
        }
    }
    public void PlayAgain()
    {
        gameOver = true;
        StartCoroutine(PlayAgainCoroutine());
    }
    IEnumerator PlayAgainCoroutine()
    {
        yield return new WaitForSeconds(2);
        gameObject.GetComponent<SceneCtrl>().ChangeScene("" + level);
    }
}