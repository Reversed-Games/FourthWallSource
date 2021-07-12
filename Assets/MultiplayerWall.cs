using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MultiplayerWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        PhotonNetwork.LoadLevel("Multiplayer1");
    }
}
