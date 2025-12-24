using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float gameSpeed = 5f;
    public float speedIncreaseRate = 0.2f;

    public float score;
    public TextMeshProUGUI scoreText;

    public GameObject gameOverUI;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    void Update()
    {
        // Increase speed over time
        gameSpeed += speedIncreaseRate * Time.deltaTime;

        // Increase score over time
        score += Time.deltaTime * 10f;
        scoreText.text = "Score: " + Mathf.FloorToInt(score);
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}