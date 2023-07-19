using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Riferimento all'audio source per la musica
    private AudioSource musicSource;

    // Mantieni il AudioManager tra le scene
    private static AudioManager instance = null;
    public static AudioManager Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);

        // Ottieni l'AudioSource
        musicSource = GetComponent<AudioSource>();
    }

    // Funzione per avviare la riproduzione della musica
    public void PlayMusic(AudioClip musicClip)
    {
        musicSource.clip = musicClip;
        musicSource.Play();
    }

    // Funzione per fermare la riproduzione della musica
    public void StopMusic()
    {
        musicSource.Stop();
    }
}
