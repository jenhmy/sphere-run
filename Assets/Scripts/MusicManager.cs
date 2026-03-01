using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;  // Instancia estática para asegurarnos de que solo haya un MusicManager en toda la aplicación
    public static MusicManager Instance { get { return instance; } } // getter público
    public AudioSource musicSource;  // AudioSource que reproducirá la música de fondo

    void Awake()
    {
        if (instance == null) // Si todavía no existe ninguna instancia de MusicManager
        {
            instance = this; // Esta será la instancia principal
            DontDestroyOnLoad(this.gameObject); // Evita que este objeto se destruya al cambiar de escena
        }
        else
        { 
            Destroy(this.gameObject); // Si ya existía otro MusicManager, destruye este objeto para evitar duplicados
        }
    }
    public void SetVolume(float value)
    {
        if (musicSource != null) // Si hay un AudioSource asignado
            musicSource.volume = value; // Cambia su volumen
    }
}
