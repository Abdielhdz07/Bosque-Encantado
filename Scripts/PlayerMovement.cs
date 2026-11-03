using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 8f;
    public Transform groundCheck;
    public float groundRadius = 0.1f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool mirandoDerecha = true;
    private float movimientoHorizontal;

    // Sonidos de pasos
    private float pasoCooldown = 0.25f;
    private float pasoTimer = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal");
        pasoTimer -= Time.deltaTime;

        // Sonido de pasos
        if (movimientoHorizontal != 0 && EstaEnSuelo() && pasoTimer <= 0f)
        {
            pasoTimer = pasoCooldown;

            if (AudioManager.Instance != null)
                AudioManager.Instance.PlayPaso();
        }

        // Saltar
        if (Input.GetKeyDown(KeyCode.Space) && EstaEnSuelo())
            Saltar();

        // Girar sprite
        if (movimientoHorizontal > 0 && !mirandoDerecha) Voltear();
        else if (movimientoHorizontal < 0 && mirandoDerecha) Voltear();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(movimientoHorizontal * velocidad, rb.velocity.y);
    }

    void Saltar()
    {
        rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);

        if (AudioManager.Instance != null)
            AudioManager.Instance.PlaySalto();
    }

    bool EstaEnSuelo()
    {
        return Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundLayer);
    }

    void Voltear()
    {
        mirandoDerecha = !mirandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }
}
