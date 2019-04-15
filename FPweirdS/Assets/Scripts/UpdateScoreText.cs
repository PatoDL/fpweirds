using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UpdateScoreText : MonoBehaviour
{
    public Text ScoreText;

    void Start()
    {
        updateScoreText();
    }

    void Update()
    {
        updateScoreText();
    }

    void updateScoreText()
    {
        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            ScoreText.text = "Your Final Score is: " + GameObject.Find("GameManager").GetComponent<GameManager>().Score;
        }
        else
        {
            ScoreText.text = "Score: " + GameObject.Find("GameManager").GetComponent<GameManager>().Score;
        }
    }
}
