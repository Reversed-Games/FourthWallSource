using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuScript : MonoBehaviour
{
    public Text multitext;
    public GameObject menu;
    public GameObject gamemode;
    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void PlayButtonClicked()
    {
        menu.SetActive(false);
        gamemode.SetActive(true);
    }

    public void ExitButtonClicked()
    {
        Application.Quit();
    }

    public void MultiplayerButtonClicked()
    {
        SceneManager.LoadScene("MultiplayerMenu");
    }
}
