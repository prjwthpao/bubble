using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))] // Assicura che lo script venga utilizzato solo su oggetti con un componente Button.
public class ButtonSFX : MonoBehaviour
{
    public AudioSource sfxAudioSource; // Riferimento all'AudioSource responsabile degli SFX per questo pulsante.
    public AudioClip buttonClickSFX; // Clip audio dell'SFX da riprodurre quando si preme il pulsante.

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(PlayButtonClickSFX);
    }

    private void PlayButtonClickSFX()
    {
        if (sfxAudioSource != null && buttonClickSFX != null)
        {
            sfxAudioSource.PlayOneShot(buttonClickSFX);
        }
    }
}
