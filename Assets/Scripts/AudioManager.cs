using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Sonidos del jugador")]
    public AudioClip paso;
    public AudioClip salto;
    public AudioClip dano;
    public AudioClip muerte;

    private AudioSource audioSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // Si quieres que siga entre escenas:
            // DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.playOnAwake = false;
        audioSource.spatialBlend = 0f;  // 2D
    }

    public void PlaySound(AudioClip clip, float volume = 1f)
    {
        if (clip == null) return;
        audioSource.PlayOneShot(clip, volume);
    }

    public void PlayPaso() => PlaySound(paso, 0.4f);
    public void PlaySalto() => PlaySound(salto, 0.7f);
    public void PlayDano() => PlaySound(dano, 0.8f);
    public void PlayMuerte() => PlaySound(muerte, 1f);
}
