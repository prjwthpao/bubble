using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LoginScript : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public TextMeshProUGUI errorMessageText;
    public Color errorColor = Color.red; // Colore per il messaggio di errore
    public Color successColor = Color.green; // Colore per il messaggio di successo
    public string correctPasswordKey = "CorrectPassword"; // Chiave per memorizzare la password corretta
    public string resetPassword = "prova123"; // Nuova password per il reset, puoi cambiarla come desideri

    public LoginManager loginManager;

    public string sceneToLoad = "page1"; // Sostituisci con il nome della scena da caricare dopo il login o il reset

    private string correctPassword; // Dichiarazione della variabile correctPassword a livello di classe
    private bool passwordResetSuccess; // Variabile per tenere traccia del reset della password

    private void Start()
    {
        // Carica la password corretta dalle PlayerPrefs
        if (PlayerPrefs.HasKey(correctPasswordKey))
        {
            correctPassword = PlayerPrefs.GetString(correctPasswordKey);
        }
        else
        {
            // Se la chiave non esiste (primo avvio), impostiamo una password predefinita
            correctPassword = "password123"; // Password corretta predefinita, sostituiscila con quella desiderata
            PlayerPrefs.SetString(correctPasswordKey, correctPassword);
        }

        // Imposta passwordResetSuccess a true all'avvio del gioco
        passwordResetSuccess = true;

        // All'avvio, mostra il pannello di login
        loginManager.ShowLoginPanel();
    }

    public void OnLoginButtonClicked()
    {
        string username = usernameInput.text;
        string password = passwordInput.text;

        if (password == "")
        {
            errorMessageText.text = "Inserisci una password.";
            errorMessageText.color = errorColor;
            return;
        }

        if (password == correctPassword)
        {
            // Password corretta, effettua il cambio scena
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            // Password non corretta, mostra un messaggio di errore in rosso
            errorMessageText.text = "Password errata. Riprova.";
            errorMessageText.color = errorColor;
        }
    }

    public void OnResetPasswordButtonClicked()
    {
        // Reset della password, sostituisci con la logica desiderata per il reset
        resetPassword = "prova123"; // Aggiorna la nuova password di reset
        passwordResetSuccess = true; // Imposta la variabile a true per indicare che la password è stata resettata con successo
        errorMessageText.text = "Password resettata con successo!";
        errorMessageText.color = successColor; // Imposta il colore del testo su verde per il messaggio di successo

        // Svuota il campo di input della password dopo aver resettato la password
        usernameInput.text = "";
        passwordInput.text = "";

        // Mostra il pannello di login
        loginManager.ShowLoginPanel();
    }
}
