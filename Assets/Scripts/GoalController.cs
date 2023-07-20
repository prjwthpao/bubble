using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalController : MonoBehaviour
{
    // Numero minimo di amici richiesti
    private int friendsRequired = 3;
    private ItemCollector itemCollector; // Riferimento all'altro script

    private void Start()
    {
        // Ottieni il riferimento all'altro script
        itemCollector = FindObjectOfType<ItemCollector>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se l'oggetto che ha attivato il trigger è il giocatore
        if (other.CompareTag("Player"))
        {
            // Ottieni il numero di amici che il giocatore ha collezionato
            int collectedFriends = itemCollector.GetCollectedFriends();

            // Controlla se il giocatore ha collezionato il numero richiesto di amici
            if (collectedFriends >= friendsRequired)
            { 
                // Il giocatore ha raggiunto l'uscita e ha vinto la partita
                // Esegui le azioni desiderate per la vittoria
                Debug.Log("Hai vinto la partita!");

                // Carica la scena "Win"
                SceneManager.LoadScene("Win");
            }
        }
    }
}
