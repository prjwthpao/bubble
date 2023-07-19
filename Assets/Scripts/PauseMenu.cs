using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public PlayerController playerController; // Riferimento al componente PlayerController del personaggio.

    private bool isPauseOpen = false;

    private void Start()
    {
        // Assicurati che il pannello delle impostazioni sia disattivato all'avvio del gioco
        pausePanel.SetActive(false);
    }

    public void TogglePauseMenu()
    {
        isPauseOpen = !isPauseOpen;

        if (isPauseOpen)
        {
            // Se il menu è stato appena aperto, disabilita il movimento del personaggio.
            playerController.SetCanMove(false);
            // Salva lo stato del gioco
            SaveGame();
        }
        else
        {
            // Se il menu è stato chiuso, riabilita il movimento del personaggio.
            playerController.SetCanMove(true);
        }

        pausePanel.SetActive(isPauseOpen);
    }

    private void SaveGame()
    {
        // Salva lo stato del gioco usando PlayerPrefs o qualsiasi altro metodo di salvataggio
        PlayerPrefs.SetInt("isGameInProgress", 1);
        PlayerPrefs.SetInt("currentLevel", SceneManager.GetActiveScene().buildIndex); // Memorizza il livello corrente
        // Altri dati del gioco da salvare, come punteggi, posizione del giocatore, ecc.
        PlayerPrefs.Save();
    }
}
