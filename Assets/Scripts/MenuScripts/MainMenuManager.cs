using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SceneIndex
{
    MainMenu = 0,
    Game = 1
}

public class MainMenuManager : MonoBehaviour
{
    [SerializeField]
    SettingsManager _settingsManager;
    private void Awake()
    {
        _settingsManager.gameObject.SetActive(false);
    }
    public void OnStartButtonClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene((int)SceneIndex.Game);
    }

    public void OnSettingsButtonClick()
    { 
        _settingsManager.gameObject.SetActive(true);
    }

    public void OnExitButtonClick()
    {
        Debug.Log("Exit button clicked");
        Application.Quit();
    }
}
