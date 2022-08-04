using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public AudioSource[] sources = new AudioSource[2];
    public GameObject platform;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            platform.SetActive(!platform);
            sources[0].Play();
            sources[1].Play();
        }
    }
}
