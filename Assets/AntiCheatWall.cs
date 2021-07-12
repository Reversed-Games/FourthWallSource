using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiCheatWall : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "test")
        {
            AntiCheat.ReversedAntiCheat.KickPlayerFromServer("Test");
        }
    }
}
