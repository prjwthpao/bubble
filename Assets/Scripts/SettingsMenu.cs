using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsPanel;
    public Slider musicVolumeSlider;
    public MusicManager musicManager;
    public PlayerController playerController; // Riferimento al componente PlayerController del personaggio.

    private bool isSettingsOpen = false;

    private void Start()
    {
        // Assicurati che il pannello delle impostazioni sia disattivato all'avvio del gioco.
        settingsPanel.SetActive(false);

        // Controlla se è presente un valore salvato per il volume della musica.
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            float savedVolume = PlayerPrefs.GetFloat("MusicVolume");
            musicVolumeSlider.value = savedVolume;
            musicManager.UpdateMusicVolume(savedVolume);
        }

        // Aggiungi un listener per l'evento OnValueChanged dello slider.
        musicVolumeSlider.onValueChanged.AddListener(OnMusicVolumeChanged);
    }

    public void ToggleSettingsMenu()
    {
        isSettingsOpen = !isSettingsOpen;

        if (isSettingsOpen)
        {
            // Se il menu è stato appena aperto, disabilita l'input del movimento del personaggio.
            playerController.SetCanMove(false);
        }
        else
        {
            // Se il menu è stato chiuso, riabilita l'input del movimento del personaggio.
            playerController.SetCanMove(true);
        }

        settingsPanel.SetActive(isSettingsOpen);
    }

    public void OnMusicVolumeChanged(float volume)
    {
        // Invia l'aggiornamento del volume alla classe MusicManager.
        musicManager.UpdateMusicVolume(volume);
    }
}
