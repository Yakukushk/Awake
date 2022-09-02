using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

interface IMessage {
    public string txt { get; set; }
}
public class ParkCollider : MonoBehaviour
{
    private bool IsEnter_ = false;
    private bool IsStay_ = false;
    private bool IsAudio_ = false;
    public GameObject PointA;
    public GameObject PointB;
    public GameObject[] Action;
    public GameObject collider;
    public GameObject lightArea = null;
   // [SerializeField] private AudioSource audioSource;
    public float mindist = 30f;
    public float dist = 0.0f;


    public Volume volume;
    FilmGrain filmGrain;



    private void OnTriggerEnter(Collider other)
    {
        Action[0].SetActive(true);
        Action[1].SetActive(false);
        lightArea.SetActive(true);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player") {
            if (IsStay_)
            {
                string txt = "Eroor";
                Debug.Log(txt);
            }
            else {
                if (volume.profile.TryGet(out filmGrain)) {
                    filmGrain.intensity.value = 10f;
                }
                AudioDistance();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            if (volume.profile.TryGet(out filmGrain)) {
                filmGrain.intensity.value = 0f;
            }
            if (other.tag == "Player")
            {
                if (IsEnter_)
                {
                    Action[0].SetActive(true);
                    Action[1].SetActive(false);
                    Action[2].SetActive(false);
                    lightArea.SetActive(true);
                }
                else
                {
                    Action[0].SetActive(false);
                    Action[1].SetActive(true);
                    Action[2].SetActive(true);
                    lightArea.SetActive(false);
                }
            }
            gameObject.SetActive(false);
            collider.SetActive(true);
            lightArea.SetActive(false);
        }
    }
 

    void AudioDistance() {
        dist = Vector3.Distance(PointA.transform.position, PointB.transform.position);
        if (dist <= mindist)
        {
            if (IsAudio_)
            {
              //  audioSource.enabled = false;
            }
            else
            {
              //audioSource.enabled = true;
            }
        }
        else {
           // audioSource.enabled = false;
        }
    }
}
