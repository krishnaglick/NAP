
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

  public GameObject MenuPanel;

  // Use this for initialization
  void Start()
  {
    MenuPanel.SetActive(true);
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void StartGame()
  {
    Debug.Log("Starting Game");
    SceneManager.LoadScene("StageOne");

  }

  public void QuitGame()
  {
    Application.Quit();
  }
}
