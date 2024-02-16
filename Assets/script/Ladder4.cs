using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder4 : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = new Vector3(313.4f, 11.5f, 211f);
            Invoke("On", .05f);
        }
    }

    void On()
    {
        player.GetComponent<CharacterController>().enabled = true;
    }
}
