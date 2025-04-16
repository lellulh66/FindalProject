using UnityEngine;
using UnityEngine.SceneManagement; // Optional if you want to reload or change scenes

public class GameTimer : MonoBehaviour
{
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

    void TriggerGameOver()
    {
        gameOver = true;
        Debug.Log("Game Over!");
    }

    public float GetTimeRemaining()
    {
        return currentTime;
    }
}