using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class AntiCheat : MonoBehaviour
{
    public static AntiCheat ReversedAntiCheat;
    public void KickPlayerFromServer(string reason)
    {
        PhotonNetwork.LeaveRoom();
        Debug.Log("DISCONNECTED: " + reason);
    }

    public void BanFromMultiplayer()
    {
        PhotonNetwork.Disconnect();
        Debug.Log("User is now banned from Multiplayer");
    }
}
