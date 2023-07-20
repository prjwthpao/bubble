using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginManager : MonoBehaviour
{
    public GameObject loginPanel;
    public GameObject registerPanel;
    public GameObject forgottenPasswordPanel;
    public GameObject resetPasswordPanel;

    private GameObject currentPanel;

    private void Start()
    {
        // All'avvio, mostriamo solo il pannello di login
        currentPanel = loginPanel;
        loginPanel.SetActive(true);
        registerPanel.SetActive(false);
        forgottenPasswordPanel.SetActive(false);
        resetPasswordPanel.SetActive(false);
    }

    public void ShowPanel(GameObject panelToShow)
    {
        // Nascondi il pannello corrente
        currentPanel.SetActive(false);

        // Mostra il nuovo pannello
        panelToShow.SetActive(true);

        // Aggiorna il riferimento al pannello corrente
        currentPanel = panelToShow;
    }

    public void ShowRegisterPanel()
    {
        ShowPanel(registerPanel);
    }

    public void ShowForgottenPasswordPanel()
    {
        ShowPanel(forgottenPasswordPanel);
    }

    public void ShowResetPasswordPanel()
    {
        ShowPanel(resetPasswordPanel);
    }
    public void ShowLoginPanel(){
        ShowPanel(loginPanel);
    }
}
