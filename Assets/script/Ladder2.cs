using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder2 : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = new Vector3(274.6f, 11.5f, 189f);
            Invoke("On", .05f);
        }
    }

    void On()
    {
        player.GetComponent<CharacterController>().enabled = true;
    }
}
