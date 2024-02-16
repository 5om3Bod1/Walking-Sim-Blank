using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tPopUp : MonoBehaviour
{

    public GameObject text;

    // Update is called once per frame

    private void Start()
    {
        text.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            text.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(text, 10f);
        }
    }
}
