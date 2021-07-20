using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SidebarScript : MonoBehaviour
{
    public GameObject console;
    public bool active = false;
    public GameObject pausegui;
    public GamemodeManager mode;
    public GameObject maincamera;
    public GameObject player;
    public GameObject third;


    public void ResumeGame()
    {
        if (mode.Instance.gamemode == "timer")
        {
            Timer.GetTimer.watch.Start();
            Debug.Log("Game has been resumed");
            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            pausegui.SetActive(false);
            third.GetComponent<FirstPersonLook>().enabled = true;
            maincamera.GetComponent<FirstPersonLook>().enabled = true;
            player.GetComponent<Crouch>().enabled = true;
            player.GetComponent<Jump>().enabled = true;
        }
        if (mode.Instance.gamemode == "maker" || mode.Instance.gamemode == "storymode")
        {
            Debug.Log("Game has been resumed");
            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            pausegui.SetActive(false);
            third.GetComponent<FirstPersonLook>().enabled = true;
            maincamera.GetComponent<FirstPersonLook>().enabled = true;
            player.GetComponent<Crouch>().enabled = true;
            player.GetComponent<Jump>().enabled = true;
        }
        // Timer.GetTimer.watch.Start();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        pausegui.SetActive(false);
        Time.timeScale = 1;
        Debug.Log("Game has been resumed");
        maincamera.GetComponent<FirstPersonLook>().enabled = true;
        player.GetComponent<Crouch>().enabled = true;
        player.GetComponent<Jump>().enabled = true;
        third.GetComponent<FirstPersonLook>().enabled = true;
    }

    public void Console()
    {
        if (active == false)
        {
            active = true;
            console.SetActive(true);
        }
        else
        {
            active = false;
            console.SetActive(false);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GotoMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
