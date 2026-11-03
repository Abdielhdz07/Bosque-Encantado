using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void JugarJuego()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Bosque_Level01");
    }

    public void IrAOptions()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void SalirJuego()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
