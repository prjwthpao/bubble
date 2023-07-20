using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
  public GameObject menuPanel;
  public GameObject exitPanel;
  public GameObject settingsPanel;

  private GameObject currentPanel;

  private void Start()
  {
      // All'avvio, mostriamo solo il pannello di login
      currentPanel = menuPanel;
      menuPanel.SetActive(true);
      exitPanel.SetActive(false);
      settingsPanel.SetActive(false);
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

  public void ShowExitPanel()
  {
      ShowPanel(exitPanel);
  }

  public void ShowSettingPanel(){
    ShowPanel(settingsPanel);
  }
}
