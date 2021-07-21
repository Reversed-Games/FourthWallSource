using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FreeplayScript : MonoBehaviour
{
    public GameObject freeplay;
    public GameObject gamemode;

    public void LevelOneBtn()
    {
        SceneManager.LoadScene("FPLvl1");
    }
    public void LevelTwoBtn()
    {
        SceneManager.LoadScene("FPLvl2");
    }
    public void LevelThreeBtn()
    {
        SceneManager.LoadScene("FPLvl3");
    }
    public void LevelFourBtn()
    {
        SceneManager.LoadScene("FPLvl4");
    }

    public void LevelFiveBtn()
    {
        SceneManager.LoadScene("FPLvl5");
    }
    public void LevelSixBtn()
    {
        SceneManager.LoadScene("FPLvl6");
    }
    public void LevelSevenBtn()
    {
        SceneManager.LoadScene("FPLvl7");
    }
    public void LevelEightBtn()
    {
        SceneManager.LoadScene("FPLvl8");
    }
    public void LevelNineBtn()
    {
        SceneManager.LoadScene("FPLvl9");
    }

    public void LevelTenBtn()
    {
        SceneManager.LoadScene("FPLvl10");
    }

    public void GoBack()
    {
        gamemode.SetActive(true);
        freeplay.SetActive(false);
    }
}
