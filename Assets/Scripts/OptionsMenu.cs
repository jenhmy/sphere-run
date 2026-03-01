using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Slider musicSlider;          // el slider en OptionsPanel
    public MusicManager musicManager;   // tu MusicManager persistente

    void Start()
    {
        if (musicManager.musicSource == null) return;

        // Si ya hay un valor guardado, usarlo; si no, usar el valor actual del AudioSource
        float savedVolume = PlayerPrefs.GetFloat("MusicVolume", musicManager.musicSource.volume);
        musicSlider.value = savedVolume;
        musicManager.SetVolume(savedVolume);

        // Listener para cambiar volumen en tiempo real
        musicSlider.onValueChanged.AddListener(SetMusicVolume);
    }

    void SetMusicVolume(float value)
    {
        musicManager.SetVolume(value);
        PlayerPrefs.SetFloat("MusicVolume", value);
    }
}
