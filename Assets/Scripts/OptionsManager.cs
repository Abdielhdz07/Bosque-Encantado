using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class OptionsManager : MonoBehaviour
{
    [Header("UI")]
    public Slider sliderBrillo;
    public Slider sliderMusica;
    public Slider sliderEfectos;
    public TMP_Dropdown dropdownDificultad; // Si no lo usas aún, puedes dejarlo vacío

    [Header("Audio")]
    public AudioMixer audioMixer; // aquí va tu GameAudio.mixer

    // Nombres EXACTOS de los parámetros expuestos en el Mixer
    private const string PARAM_MUSICA = "MusicaVol";
    private const string PARAM_EFECTOS = "EfectosVol";
    private const string PREF_BRILLO = "Brillo";

    private void Start()
    {
        // 🔹 Cargar valores guardados (si no hay, usar 1 como default)
        float brillo = PlayerPrefs.GetFloat(PREF_BRILLO, 1f);
        float volMusica = PlayerPrefs.GetFloat(PARAM_MUSICA, 1f);
        float volEfectos = PlayerPrefs.GetFloat(PARAM_EFECTOS, 1f);

        sliderBrillo.value = brillo;
        sliderMusica.value = volMusica;
        sliderEfectos.value = volEfectos;

        // 🔹 Aplicar inmediatamente
        CambiarBrillo(brillo);
        CambiarMusica(volMusica);
        CambiarEfectos(volEfectos);

        // 🔹 Suscribir eventos
        sliderBrillo.onValueChanged.AddListener(CambiarBrillo);
        sliderMusica.onValueChanged.AddListener(CambiarMusica);
        sliderEfectos.onValueChanged.AddListener(CambiarEfectos);
    }

    public void CambiarBrillo(float valor)
    {
        // Solo guardamos, el brillo real se aplica en la escena del juego
        PlayerPrefs.SetFloat(PREF_BRILLO, valor);
        PlayerPrefs.Save();
    }

    public void CambiarMusica(float valor)
    {
        // Evitar log10(0)
        float v = Mathf.Clamp(valor, 0.0001f, 1f);
        audioMixer.SetFloat(PARAM_MUSICA, Mathf.Log10(v) * 20f);

        PlayerPrefs.SetFloat(PARAM_MUSICA, valor);
        PlayerPrefs.Save();
    }

    public void CambiarEfectos(float valor)
    {
        float v = Mathf.Clamp(valor, 0.0001f, 1f);
        audioMixer.SetFloat(PARAM_EFECTOS, Mathf.Log10(v) * 20f);

        PlayerPrefs.SetFloat(PARAM_EFECTOS, valor);
        PlayerPrefs.Save();
    }
}

