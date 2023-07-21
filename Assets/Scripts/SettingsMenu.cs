using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsPanel;
    public Slider musicVolumeSlider;
    public Slider soundVolumeSlider; // Aggiungi questo campo per lo slider del volume del suono
    public MusicManager musicManager;
    public ItemCollector itemCollector; // Riferimento al componente ItemCollector del personaggio.
    public PlayerController playerController;

    private bool isSettingsOpen = false;

    private void Start()
    {
        settingsPanel.SetActive(false);

        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            float savedMusicVolume = PlayerPrefs.GetFloat("MusicVolume");
            musicVolumeSlider.value = savedMusicVolume;
            musicManager.UpdateMusicVolume(savedMusicVolume);
        }

        if (PlayerPrefs.HasKey("SoundVolume"))
        {
            float savedSoundVolume = PlayerPrefs.GetFloat("SoundVolume");
            soundVolumeSlider.value = savedSoundVolume;
            itemCollector.UpdateSoundVolume(savedSoundVolume);
        }

        musicVolumeSlider.onValueChanged.AddListener(OnMusicVolumeChanged);
        soundVolumeSlider.onValueChanged.AddListener(OnSoundVolumeChanged); // Aggiungi questo listener per l'evento OnValueChanged dello slider del suono
    }

    public void ToggleSettingsMenu()
    {
        isSettingsOpen = !isSettingsOpen;

        if (isSettingsOpen)
        {
            playerController.SetCanMove(false);
        }
        else
        {
            playerController.SetCanMove(true);
        }

        settingsPanel.SetActive(isSettingsOpen);
    }

    public void OnMusicVolumeChanged(float volume)
    {
        musicManager.UpdateMusicVolume(volume);
    }

    public void OnSoundVolumeChanged(float volume)
    {
        itemCollector.UpdateSoundVolume(volume);
    }
}
