using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamemodeManager : MonoBehaviour
{
    public string gamemode = "";
    [HideInInspector] public GamemodeManager Instance;

    public void Awake()
    {
        Instance = this;
    }
}
