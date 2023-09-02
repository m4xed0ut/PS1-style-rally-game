using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacenoteReader : MonoBehaviour
{
    public AudioClip pacenote;
    public AudioSource pn;


    void Start()
    {
        pn.playOnAwake = false;
        pn.clip = pacenote;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            pn.Play();
        }
    }
}
