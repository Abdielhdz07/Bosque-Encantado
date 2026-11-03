using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("UI")]
    public TMP_Text scoreText;   // Referencia al texto "Score: 0"

    int score = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // Si quieres que sobreviva entre escenas:
            // DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        score = 0;
        UpdateScoreUI();
    }

    // 👉 Llama a esto desde donde quieras sumar puntos
    public void AddScore(int amount)
    {
        score += amount;
        if (score < 0) score = 0;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    // Lo dejo porque tu PlayerHealth lo usa
    public void GameOver()
    {
        Debug.Log("GAME OVER");

        // Aquí puedes mostrar un panel, reiniciar escena, etc.
        // Ejemplo:
        // Time.timeScale = 0f;
        // gameOverPanel.SetActive(true);
    }
}
