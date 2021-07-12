using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlrGroundCheck : MonoBehaviour
{
    PlayerController player;
    // Start is called before the first frame update
    private void Awake()
    {
        player = GetComponentInParent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player.gameObject)
            return;
        player.setGrounded(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player.gameObject)
            return;
        player.setGrounded(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player.gameObject)
            return;
        player.setGrounded(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player.gameObject)
            return;
        player.setGrounded(true);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == player.gameObject)
            return;
        player.setGrounded(false);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject == player.gameObject)
            return;
        player.setGrounded(true);
    }
}
