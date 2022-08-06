using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsAnimation : MonoBehaviour
{

    

    [SerializeField] private bool opendoor = false;
    [SerializeField] private Animator animator = null;
    [SerializeField] private AudioSource audioSource = null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            if (opendoor) {
                animator.Play("New Animation", 0, 0.0f);
                audioSource.Play();
                gameObject.SetActive(false);
                
            }
        }
    }
}
