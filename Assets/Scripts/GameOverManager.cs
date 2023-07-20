using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
  public GameObject gameOverPanel;
  public GameObject exitPanel;

  private GameObject currentPanel;

  private void Start()
  {
      // All'avvio, mostriamo solo il pannello di login
      currentPanel = gameOverPanel;
      gameOverPanel.SetActive(true);
      exitPanel.SetActive(false);
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
}
