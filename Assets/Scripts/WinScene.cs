using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadMainMenu", 5); //Invoca despues de 4sec el Menu

    }

    public void LoadMainMenu() //Carga MainMenu
    {
        SceneManager.LoadScene("MainMenu");
    }
}
