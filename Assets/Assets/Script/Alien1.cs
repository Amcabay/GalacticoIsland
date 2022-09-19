using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien1: MonoBehaviour
{
    public GameObject alienGuy;

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Jika player di sekitar object yang bisa interaksi
        if (other.tag == "Player")
        {
            alienGuy.SetActive(false);
        }
    }
}
