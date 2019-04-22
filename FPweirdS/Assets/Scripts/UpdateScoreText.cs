using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UpdateScoreText : MonoBehaviour
{
    public Text ScoreText;
    GameObject gm;

    void Start()
    {
        gm = GameObject.Find("GameManager");
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
            ScoreText.text = "Your Final Score is: " + gm.GetComponent<GameManager>().Score;
        }
        else
        {
            ScoreText.text = "Score: " + gm.GetComponent<GameManager>().Score;
        }
    }
}
