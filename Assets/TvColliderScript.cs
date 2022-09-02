using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.Rendering;
using UnityEngine.UI;

interface ITvColliderScript {
    
}
public class TvColliderScript : MonoBehaviour, ITvColliderScript
{
    // Post
    public Volume volume;
    FilmGrain filmGrain_;

    // Bools 
    private bool IsStay_ = false;
    private bool IsExit_ = false;

    //Audio
    [SerializeField] private AudioSource audioSource = null;

    //Text
    public GameObject text;


    private void Start()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player") {
            if (IsStay_)
            {
                string txt = "ErrorStay";
                Debug.Log(txt);
                if (volume.profile.TryGet(out filmGrain_))
                {
                    filmGrain_.intensity.value = 0.0f;
                 }
                audioSource.Stop();
            }
            else {
                if (volume.profile.TryGet(out filmGrain_))
                {
                    filmGrain_.intensity.value = 10f;
                }
                audioSource.enabled = true;
                text.SetActive(true);
                Debug.Log("Working");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            if (IsExit_)
            {
                string txt = "ErrorExit";
                Debug.Log(txt);
                if (volume.profile.TryGet(out filmGrain_))
                {
                    filmGrain_.intensity.value = 10f;
                    audioSource.Play();
                }
            }
            else {
                if (volume.profile.TryGet(out filmGrain_))
                {
                    filmGrain_.intensity.value = 0.0f;
                    
                   
                }
                audioSource.enabled = false;
                text.SetActive(false);
            }
        }
    }


}
