using UnityEngine;
using UnityEngine.UI;

public class TextInputController : MonoBehaviour
{
    public InputField inputField;

    private void Update()
    {
        // Controlla se il campo di testo ha il focus e se il tasto Invio è stato premuto
        if (inputField.isFocused && Input.GetKeyDown(KeyCode.Return))
        {
            // Esegui qui le azioni che desideri fare con il testo inserito nel campo
            string inputText = inputField.text;
            Debug.Log("Testo inserito: " + inputText);
        }
    }
}
