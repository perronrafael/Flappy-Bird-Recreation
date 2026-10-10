using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

    // Variables
    private int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;

    public void IncreasePlayerScore(int scoreToIncrease)
    {
        playerScore += scoreToIncrease;
        scoreText.text = playerScore.ToString();
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
