using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Secret : MonoBehaviour
{
    // Reversed Game Studio Presents
    private void OnCollisionEnter(Collision collision)
    {
        if (SceneManager.GetActiveScene().name == "Lvl1")
        {
            SceneManager.LoadScene("Secret");

        }
        if (SceneManager.GetActiveScene().name == "SRLvl1")
        {
            SceneManager.LoadScene("SRSecret");
        }
    }

    // Our first ever game
}
