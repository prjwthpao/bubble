using UnityEngine;

public class ExitMenu : MonoBehaviour
{
    public GameObject exitPanel;
    public PauseMenu pauseMenu; // Aggiungi questa variabile per il riferimento al PauseMenu.

    private bool isExitOpen = false;

    private void Start()
    {
        // Assicurati che il pannello di pausa sia disattivato all'avvio del gioco.
        exitPanel.SetActive(false);
    }
    
    public void ToggleExitMenu()
    {
        isExitOpen = !isExitOpen;

        // Chiudi il menu di pausa se è aperto quando viene aperto l'Exit Menu.
        if (isExitOpen && pauseMenu != null && pauseMenu.IsPauseOpen())
        {
            pauseMenu.TogglePauseMenu();
        }

        // Gestisci la visibilità del pannello di uscita.
        exitPanel.SetActive(isExitOpen);

        // Assicurati che il pannello di pausa sia disattivato quando l'exitPanel è attivo.
        if (pauseMenu != null && pauseMenu.IsPauseOpen() && isExitOpen)
        {
            pauseMenu.SetPauseOpen(false);
        }
    }
}
