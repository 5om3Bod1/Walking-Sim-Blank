using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barWarp : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = new Vector3(-30f, 27f, 100f);
            Invoke("On", .05f);
        }
    }

    void On()
    {
        player.GetComponent<CharacterController>().enabled = true;
    }
}
