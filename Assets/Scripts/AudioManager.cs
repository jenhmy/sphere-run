using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioClip buttonClick;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayClickSound()
    {
        if (buttonClick != null)
        {
            // Crea un AudioSource temporal y reproduce el clip
            AudioSource.PlayClipAtPoint(buttonClick, Camera.main.transform.position);
        }
    }
}
