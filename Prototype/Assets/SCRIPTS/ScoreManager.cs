using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // for restarting or changing scenes
using UnityEngine.UI; // only if you're showing the score on screen

public class ScoreManager : MonoBehaviour
{
    public int currentScore = 0;
    public int targetScore = 1; // set the score needed to win

    public TMP_Text scoreText;

    void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + currentScore;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            AddPoints(1);
        }
    }

    public void AddPoints(int points)
    {
        currentScore += points;
        UpdateScoreDisplay();

        if (currentScore >= targetScore)
        {
            EndGame();
        }
    }
    public EndScreenAnim winScreen;
    void EndGame()
    {
        Debug.Log("Game Over! You win!");
        winScreen.StartFade();
       
    }
}