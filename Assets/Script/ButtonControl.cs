using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    public GameObject pause;
    public GameObject maincamera;
    public GameObject third;
    public GameObject player;
    public GamemodeManager mode;
    public bool enablePause = false;
    
    private void Start()
    {
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        pause.SetActive(false);
        maincamera.GetComponent<FirstPersonLook>().enabled = true;
        player.GetComponent<Crouch>().enabled = true;
        player.GetComponent<Jump>().enabled = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Home))
        {
            if(enablePause == false)
            {
                if(mode.gamemode == "timer")
                {
                    Timer.GetTimer.watch.Stop();
                    Debug.Log("Game has been paused");
                    Time.timeScale = 0;
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    pause.SetActive(true);
                    third.GetComponent<FirstPersonLook>().enabled = false;
                    maincamera.GetComponent<FirstPersonLook>().enabled = false;
                    player.GetComponent<Crouch>().enabled = false;
                    player.GetComponent<Jump>().enabled = false;
                    enablePause = true;
                }
                if(mode.Instance.gamemode == "maker" || mode.Instance.gamemode == "storymode")
                {
                    Debug.Log("Game has been paused");
                    Time.timeScale = 0;
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    pause.SetActive(true);
                    third.GetComponent<FirstPersonLook>().enabled = false;
                    maincamera.GetComponent<FirstPersonLook>().enabled = false;
                    player.GetComponent<Crouch>().enabled = false;
                    player.GetComponent<Jump>().enabled = false;
                    enablePause = true;
                }
            }
            else
            {
                if (mode.Instance.gamemode == "timer")
                {
                    Timer.GetTimer.watch.Start();
                    Debug.Log("Game has been resumed");
                    Time.timeScale = 1;
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    pause.SetActive(false);
                    third.GetComponent<FirstPersonLook>().enabled = true;
                    maincamera.GetComponent<FirstPersonLook>().enabled = true;
                    player.GetComponent<Crouch>().enabled = true;
                    player.GetComponent<Jump>().enabled = true;
                    enablePause = false;
                }
                if (mode.Instance.gamemode == "maker" || mode.Instance.gamemode == "storymode")
                {
                    Debug.Log("Game has been resumed");
                    Time.timeScale = 1;
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    pause.SetActive(false);
                    third.GetComponent<FirstPersonLook>().enabled = true;
                    maincamera.GetComponent<FirstPersonLook>().enabled = true;
                    player.GetComponent<Crouch>().enabled = true;
                    player.GetComponent<Jump>().enabled = true;
                    enablePause = false;
                }
            }
            

        }
    }
}
