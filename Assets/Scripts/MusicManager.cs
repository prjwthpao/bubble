using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public AudioSource musicAudioSource;
    private float savedVolume = 1.0f;

    private void Start()
    {
        // Controlla se è presente un valore salvato per il volume della musica
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            savedVolume = PlayerPrefs.GetFloat("MusicVolume");
        }
        musicAudioSource.volume = savedVolume;
    }

    public void UpdateMusicVolume(float volume)
    {
        musicAudioSource.volume = volume;
        savedVolume = volume;
        PlayerPrefs.SetFloat("MusicVolume", volume);
    }
}
