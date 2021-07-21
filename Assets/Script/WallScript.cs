using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        // Normal Story
       if(SceneManager.GetActiveScene().name == "Lvl1")
        {
            SceneManager.LoadScene("Lvl2");
            Debug.Log("Lvl1 - Wall touched");
        }
        if (SceneManager.GetActiveScene().name == "Lvl2")
        {
            SceneManager.LoadScene("Lvl3");
            Debug.Log("Lvl2 - Wall touched");
        }
        if (SceneManager.GetActiveScene().name == "Lvl3")
        {
            SceneManager.LoadScene("Lvl4");
            Debug.Log("Lvl3 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "Lvl4")
        {
            SceneManager.LoadScene("Lvl5");
            Debug.Log("Lvl4 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "Lvl5")
        {
            SceneManager.LoadScene("Lvl6");
            Debug.Log("Lvl5 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "Lvl6")
        {
            SceneManager.LoadScene("Lvl7");
            Debug.Log("Lvl6 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "Lvl7")
        {
            SceneManager.LoadScene("Lvl8");
            Debug.Log("Lvl7 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "Lvl8")
        {
            SceneManager.LoadScene("Lvl9");
            Debug.Log("Lvl8 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "Lvl9")
        {
            SceneManager.LoadScene("Lvl10");
            Debug.Log("Lvl9 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "Lvl10")
        {
            SceneManager.LoadScene(0);
            Debug.Log("Lvl10 - Wall touched");
        }

        // Speedrun Levels
        if (SceneManager.GetActiveScene().name == "SRLvl1")
        {
            SceneManager.LoadScene("SRLvl2");
            Debug.Log("SRLvl1 - Wall touched");
        }
        if (SceneManager.GetActiveScene().name == "SRLvl2")
        {
            SceneManager.LoadScene("SRLvl3");
            Debug.Log("SRLvl2 - Wall touched");
        }
        if (SceneManager.GetActiveScene().name == "SRLvl3")
        {
            SceneManager.LoadScene("SRLvl4");
            Debug.Log("SRLvl3 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "SRLvl4")
        {
            SceneManager.LoadScene("SRLvl5");
            Debug.Log("SRLvl4 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "SRLvl5")
        {
            SceneManager.LoadScene("SRLvl6");
            Debug.Log("SRLvl5 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "SRLvl6")
        {
            SceneManager.LoadScene("SRLvl7");
            Debug.Log("SRLvl6 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "SRLvl7")
        {
            SceneManager.LoadScene("SRLvl8");
            Debug.Log("SRLvl7 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "SRLvl8")
        {
            SceneManager.LoadScene("SRLvl9");
            Debug.Log("SRLvl8 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "SRLvl9")
        {
            SceneManager.LoadScene("SRLvl10");
            Debug.Log("SRLvl9 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "SRLvl10")
        {
            SceneManager.LoadScene(0);
            Debug.Log("SRLvl10 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "SRSecret")
        {
            SceneManager.LoadScene(0);
            Debug.Log("SRSecret - Wall touched");
        }

        // Maker Level

        if (SceneManager.GetActiveScene().name == "MakerLevel")
        {
            SceneManager.LoadScene("MakerLevel");
            Debug.Log("MakerLevel - Wall touched");
        }

        // Freeplay Level

        if (SceneManager.GetActiveScene().name == "FPLvl1")
        {
            SceneManager.LoadScene(0);
            Debug.Log("FPLvl1 - Wall touched");
        }
        if (SceneManager.GetActiveScene().name == "FPLvl2")
        {
            SceneManager.LoadScene(0);
            Debug.Log("FPLvl2 - Wall touched");
        }
        if (SceneManager.GetActiveScene().name == "FPLvl3")
        {
            SceneManager.LoadScene(0);
            Debug.Log("FPLvl3 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "FPLvl4")
        {
            SceneManager.LoadScene(0);
            Debug.Log("FPLvl4 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "FPLvl5")
        {
            SceneManager.LoadScene(0);
            Debug.Log("FPLvl5 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "FPLvl6")
        {
            SceneManager.LoadScene(0);
            Debug.Log("FPLvl6 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "FPLvl7")
        {
            SceneManager.LoadScene(0);
            Debug.Log("FPLvl7 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "FPLvl8")
        {
            SceneManager.LoadScene(0);
            Debug.Log("FPLvl8 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "FPLvl9")
        {
            SceneManager.LoadScene(0);
            Debug.Log("FPLvl9 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "FPLvl10")
        {
            SceneManager.LoadScene(0);
            Debug.Log("FPLvl10 - Wall touched");
        }

        // Secret Levels (not including Speedrun)

        if (SceneManager.GetActiveScene().name == "Secret")
        {
            SceneManager.LoadScene(0);
            Debug.Log("Secret - Wall touched");
        }
    }



}
