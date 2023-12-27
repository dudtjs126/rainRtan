using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject rain;
    public GameObject panel;
    public static GameManager I;
    public Text scoreText;
    public Text timeText;
    public GameObject red_rain;
    int totalScore;
    float limit = 60f;


    void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        initGame();
        InvokeRepeating("makeRain", 0, 0.5f);
        InvokeRepeating("makeRedRain", 0, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        limit -= Time.deltaTime;

        if (limit < 0)
        {
            Time.timeScale = 0.0f;
            panel.SetActive(true);
            limit = 0.0f;
        }

        timeText.text = limit.ToString("N2");
    }

    void makeRain()
    {
        Instantiate(rain);
    }

    void makeRedRain()
    {
        Instantiate(red_rain);
    }

    public void addScore(int score)
    {
        totalScore += score;
        scoreText.text = totalScore.ToString();
    }

    public void minusScore (int minusscore)
    {
        totalScore -= minusscore;
        scoreText.text = totalScore.ToString();
    }

    public void retry()
    {
        SceneManager.LoadScene("MainScene");
    }

    void initGame()
    {
        Time.timeScale = 1.0f;
        totalScore = 0;
        limit = 60f;
    }
}
