using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseColliderScript : MonoBehaviour
{
    [SerializeField] private bool CloseDoor= false;
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            if (CloseDoor == false) {
                animator.Play("CloseDoor", 0, 0.0f);
                audioSource.Play();
                gameObject.SetActive(false);
                Debug.Log("Action");
            }
        }
    }
}
