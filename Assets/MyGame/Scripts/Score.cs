using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Score : MonoBehaviour
{
    private const string HIGHSCORE = "highScore";

    [SerializeField] TextMeshProUGUI highScoreText;

    [SerializeField] TextMeshProUGUI yourScoreText;

    private int highScore = 0, yourScore = 0;
    private int startScore = 0;
    private float nextScoreIncrease = 0f;
    
    public static bool gameStopped;

    private void Start()
    {
        yourScore = startScore;
        highScore = PlayerPrefs.GetInt(HIGHSCORE);
        gameStopped = false;
    }

     private void Update()
    {
        if (!gameStopped)
        {
            IncreaseYourScore();
        }

        highScoreText.text = "High Score: " + highScore;
        yourScoreText.text = "Your Score: " + yourScore; 
    }

    public void CharacterHit()
    {
        if (yourScore > highScore)
        {
            PlayerPrefs.SetInt("highScore", yourScore);
        }

        Time.timeScale = 0;
        gameStopped = true;
    }

    private void IncreaseYourScore()
    {
        if (Time.unscaledTime > nextScoreIncrease)
        {
            yourScore += 1;
            nextScoreIncrease = Time.unscaledTime + 1;
        }
    }
}