using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LuzRespirante : MonoBehaviour
{
    private Light2D luz;
    public float velocidad = 2f;
    public float intensidadBase = 4f;
    public float amplitud = 1f;

    void Start()
    {
        luz = GetComponent<Light2D>();
    }

    void Update()
    {
        luz.intensity = intensidadBase + Mathf.Sin(Time.time * velocidad) * amplitud;
    }
}
