using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = startingHealth;
    }
    
    public void TakeDamage(float damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - damage, 0, startingHealth);
        // Controllo se la currentHealth è <= 0, in tal caso l'oggetto muore
        if (currentHealth <= 0)
        {
            Die();
        }
        
    }

    private void Die()
    {
        // Puoi implementare qui la logica per gestire la "morte" dell'oggetto
        // Ad esempio, puoi disattivare l'oggetto, distruggerlo o eseguire altre azioni di gioco.
        // In questo esempio, sto semplicemente disattivando l'oggetto.
        Debug.Log("Hai perso il gioco!");
        SceneManager.LoadScene("GameOVer");
    }

    public void AddHealth(float value)
    {
        currentHealth = Mathf.Clamp(currentHealth + value, 0, startingHealth);
    }

}
