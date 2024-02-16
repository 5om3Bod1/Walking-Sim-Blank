using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bPole : MonoBehaviour
{
    public GameObject player;

    private void OnMouseDown()
    {
        player.GetComponent<CharacterController>().enabled = false;
        player.transform.position = new Vector3(-6f, 1f, -95f);
        Invoke("On", .05f);
    }
    void On()
    {
        player.GetComponent<CharacterController>().enabled = true;
    }
}
