using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class busPole : MonoBehaviour
{
    public GameObject player;

    private void OnMouseDown()
    {
        player.GetComponent<CharacterController>().enabled = false;
        player.transform.position = new Vector3(6.5f, 1.5f, 108f);
        Invoke("On", .05f);
    }
    void On()
    {
        player.GetComponent<CharacterController>().enabled = true;
    }
}