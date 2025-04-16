using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // for restarting or changing scenes
using UnityEngine.UI; // only if you're showing the score on screen

public class ScoreManager : MonoBehaviour
{
    public int currentScore = 0;
    public int targetScore = 1; // set the score needed to win

    public TMP_Text scoreText;
    public float timeLimit = 60f; // Time in seconds
    private float currentTime;

    private bool gameOver = false;

    void Start()
    {
        currentTime = timeLimit;
    }
    void Update()
    {
        if (gameOver) return;

        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            currentTime = 0;
            TriggerGameOver();
        }
    }
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
    public EndScreenAnim loseScreen;
    void TriggerGameOver()
    {
        gameOver = true;
        Debug.Log("Game Over! You Lose :(");
        loseScreen.StartFade();
    }
    public float GetTimeRemaining()
    {
        return currentTime;
    }

}

/*
 

   

   

    
   
 */