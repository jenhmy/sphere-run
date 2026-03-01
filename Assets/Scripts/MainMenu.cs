using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;
    public Slider volumeSlider;

    void Start()
    {
        if (mainMenuPanel != null) mainMenuPanel.SetActive(true);
        if (optionsPanel != null) optionsPanel.SetActive(false);
        if (volumeSlider != null) volumeSlider.onValueChanged.AddListener(value => MusicManager.Instance.SetVolume(value));
    }

    public void Play()
    {
        StartCoroutine(PlayClickAndLoad());
    }

    private IEnumerator PlayClickAndLoad()
    {
        AudioManager.instance.PlayClickSound(); 
        yield return new WaitForSeconds(0.3f);  
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }

    public void ToggleOptions()
    {
        bool isActive = optionsPanel.activeSelf;
        optionsPanel.SetActive(!isActive);
        AudioManager.instance.PlayClickSound(); 
    }

    public void Quit()
    {
        AudioManager.instance.PlayClickSound(); 
        Application.Quit();
    }
}
