using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
  public GameObject menuPanel;
  public GameObject settingsPanel;

  private GameObject currentPanel;

  private void Start()
  {
      // All'avvio, mostriamo solo il pannello di login
      currentPanel = menuPanel;
      menuPanel.SetActive(true);
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

  public void ShowSettingPanel(){
    ShowPanel(settingsPanel);
  }
}
