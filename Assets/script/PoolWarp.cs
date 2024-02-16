using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolWarp : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = new Vector3(247f, 15.5f, 200f);
            Invoke("On", .05f);
        }
    }

    void On()
    {
        player.GetComponent<CharacterController>().enabled = true;
    }
}
