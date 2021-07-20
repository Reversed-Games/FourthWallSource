using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamemodeScript : MonoBehaviour
{
    public GameObject gamemodePanel;
    public GameObject menuPanel;

    public void gamemodeChoosen_Story()
    {
        SceneManager.LoadScene("Lvl1");
    }

    public void gamemodeChoosen_Speedrun()
    {
        SceneManager.LoadScene("SRLvl1");
    }

    public void gamemodeChoosen_Generate()
    {
        SceneManager.LoadScene("MakerLevel");
    }

    public void goBack()
    {
        gamemodePanel.SetActive(false);
        menuPanel.SetActive(true);
    }
}
