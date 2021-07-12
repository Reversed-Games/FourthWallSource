using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class ChatScript : MonoBehaviour
{

    public Text chatBox;
    public Text playerList;
    public InputField chatInput;

    public String lvl1Path = ".\\ChatFloorLog-LevelOne.txt";


    public void Start()
    {
        File.Create(lvl1Path);

        if (SceneManager.GetActiveScene().name == "Lvl1Cutscene")
        {
            Debug.Log("1");
            StartCoroutine(Lvl1Cutscene());
        }
    }

    public void Send()
    {
        
    }

    IEnumerator Lvl1Cutscene()
    {
        yield return new WaitForSeconds(0.5f);
        File.WriteAllText(lvl1Path, "You are connected to CHATFLOORSERVER-1");
        yield return new WaitForSeconds(4);
        chatBox.text = chatBox.text + "\nUser person312 has joined the chat.";
        playerList.text = playerList.text + "\nperson312";
        File.WriteAllText(lvl1Path, File.ReadAllText(lvl1Path) + "\nUser person312 has joined the chat.");
        yield return new WaitForSeconds(0.5f);
        chatBox.text = chatBox.text + "\nperson312> hello?";

        File.WriteAllText(lvl1Path, File.ReadAllText(lvl1Path) + "\nperson312> hello?");
    }
}
