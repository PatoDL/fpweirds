using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Score;
    public bool GameOver;

    private static GameManager instance;

    public static GameManager Get()
    {
        return instance;
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        Score = 0;
    }

    void Update()
    {
        
    }

    public void AddScore(int score)
    {
        Score += score;
        Debug.Log("score: " + Score);
    }

    public void SetGO(bool g)
    {
        GameOver = g;
        SceneManager.LoadScene("GameOver");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void PlayAgain()
    {
        GameOver = false;
        Score = 0;
        SceneManager.LoadScene("Game");
    }
}
