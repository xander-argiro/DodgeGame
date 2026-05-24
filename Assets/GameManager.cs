using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class GameManager : MonoBehaviour
{

    float score;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI restartPrompt;

    public bool gameOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void GameOver() {
        gameOver = true;
        Time.timeScale = 0f;
        gameOverText.gameObject.SetActive(true);
        restartPrompt.gameObject.SetActive(true);
        

    }

    void RestartGame() {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);

    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();

        if (gameOver == true && Keyboard.current.spaceKey.isPressed)
        {
            RestartGame();
        }
    }
}
