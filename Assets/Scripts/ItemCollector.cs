using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int amiciCount = 0;

    public AudioSource soundAudioSource; // Aggiungi questo campo per l'AudioSource
    public AudioClip collectSound; // Aggiungi questo campo per l'AudioClip

    private float soundVolume = 1.0f; // Aggiungi questo campo per memorizzare il volume del suono

    private void Start()
    {
        // Ottieni o aggiungi un componente AudioSource per il suono
        soundAudioSource = gameObject.GetComponent<AudioSource>();
        if (soundAudioSource == null)
        {
            soundAudioSource = gameObject.AddComponent<AudioSource>();
        }

        // Imposta il suono associato all'AudioClip
        soundAudioSource.clip = collectSound;

        // Carica il volume del suono salvato se esiste
        if (PlayerPrefs.HasKey("SoundVolume"))
        {
            soundVolume = PlayerPrefs.GetFloat("SoundVolume");
            soundAudioSource.volume = soundVolume;
        }
    }

    public void UpdateSoundVolume(float volume)
    {
        soundVolume = volume;
        soundAudioSource.volume = volume;
        PlayerPrefs.SetFloat("SoundVolume", volume);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("amici"))
        {
            Destroy(collision.gameObject);
            amiciCount++;
            Debug.Log("amiciCount: " + amiciCount);

            // Riproduci il suono quando il personaggio tocca l'oggetto
            if (collectSound != null)
            {
                soundAudioSource.Play();
            }
        }
    }

    public int GetCollectedFriends()
    {
        return amiciCount;
    }
}
