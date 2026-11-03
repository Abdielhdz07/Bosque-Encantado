using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [Header("Vida")]
    public int maxHealth = 100;
    public int currentHealth;

    [Header("UI de Vida")]
    public Slider healthBar;
    public Image fillImage;

    Color highHealthColor = new Color32(193, 124, 255, 255); // Morado
    Color midHealthColor = new Color32(255, 102, 179, 255); // Rosa
    Color lowHealthColor = new Color32(224, 47, 107, 255);  // Magenta/rojo

    void Start()
    {
        currentHealth = maxHealth;

        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;

        UpdateHealthBar();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth < 0)
            currentHealth = 0;

        // 🔊 sonido de daño
        if (AudioManager.Instance != null)
            AudioManager.Instance.PlayDano();

        UpdateHealthBar();

        if (currentHealth == 0)
            Die();
    }

    void UpdateHealthBar()
    {
        healthBar.value = currentHealth;

        float porcentaje = (float)currentHealth / maxHealth;

        if (porcentaje > 0.6f)
            fillImage.color = highHealthColor;
        else if (porcentaje > 0.3f)
            fillImage.color = midHealthColor;
        else
            fillImage.color = lowHealthColor;
    }

    void Die()
    {
        Debug.Log("El jugador murió");

        // 🔊 sonido de muerte
        if (AudioManager.Instance != null)
            AudioManager.Instance.PlayMuerte();

        // Si tienes GameManager, llama GameOver
        if (GameManager.Instance != null)
            GameManager.Instance.GameOver();

        // Si luego quieres desactivar movimiento:
        // GetComponent<PlayerMovement>().enabled = false;
    }
}
