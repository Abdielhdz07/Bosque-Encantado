using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance;

    private void Awake()
    {
        // Si ya existe otro MusicManager, destruye este para no duplicar música
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // Este será el único MusicManager
        Instance = this;

        // No destruir este objeto al cambiar de escena
        DontDestroyOnLoad(gameObject);
    }
}
