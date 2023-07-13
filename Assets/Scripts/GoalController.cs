using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se l'oggetto che ha attivato il trigger è il giocatore
        if (other.CompareTag("Player"))
        {
            // Il giocatore ha raggiunto l'uscita e ha vinto la partita
            // Esegui le azioni desiderate per la vittoria
            Debug.Log("Hai vinto la partita!");

            // Carica la scena "Win"
            SceneManager.LoadScene("Win");
        }
    }
}
