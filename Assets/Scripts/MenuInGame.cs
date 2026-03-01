using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuInGame : MonoBehaviour
{
    public void LoadMainMenu()
    {
        StartCoroutine(PlayClickAndLoad());
    }

    private IEnumerator PlayClickAndLoad()
    {
        AudioManager.instance.PlayClickSound(); // Reproduce el clic
        yield return new WaitForSeconds(0.3f);  // Espera un instante para que suene
        SceneManager.LoadScene("MainMenu");     // Luego carga la escena
    }

    public void Quit()
    {
        AudioManager.instance.PlayClickSound(); // Reproduce clic
        Application.Quit();                      // Cierra el juego
    }
}
