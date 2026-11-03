using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 20;
    public int enemyHealth = 40;

    private bool isDead = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<PlayerHealth>().TakeDamage(damage);
        }
    }

    // 👉 Llama a esto desde donde golpees al enemigo
    public void TakeHit(int amount)
    {
        if (isDead) return;

        enemyHealth -= amount;

        if (enemyHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;

        // ⭐ SUMAR SCORE CUANDO MUERE EL ENEMIGO
        if (GameManager.Instance != null)
        {
            GameManager.Instance.AddScore(10);  // Cambia 10 por los puntos que quieras
        }

        // Destruir enemigo
        Destroy(gameObject);
    }
}
