using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolExit : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = new Vector3(40.75f, 1f, 213f);
            Invoke("On", .05f);
        }
    }

    void On()
    {
        player.GetComponent<CharacterController>().enabled = true;
    }
}
