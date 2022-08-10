using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;



public class Post : MonoBehaviour
{

    public Volume volume;
    public AudioSource[] sources = new AudioSource[4];
    ChromaticAberration chromaticAberration;
    FilmGrain filmGrain;
    bool sourceActive = true;
    public GameObject eyes;
    public GameObject[] eyesObject = new GameObject[5];
    public GameObject[] lightpanels = new GameObject[3];
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            if (volume.profile.TryGet(out chromaticAberration) && volume.profile.TryGet(out filmGrain))
            {
                //Adjust your lens here. ie
                chromaticAberration.intensity.value = 2020f;
                filmGrain.intensity.value = 10f;
              
            }
            sources[0].enabled = sourceActive;
            sources[1].enabled = sourceActive;
            sources[2].enabled = sourceActive;
            StartCoroutine(enumerator());
            StartCoroutine(eyesEnuerator());
            eyes.SetActive(eyes);
            Debug.Log("Changed");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            gameObject.SetActive(false);
    }

    IEnumerator enumerator() {
        lightpanels[0].SetActive(true);
        sources[3].Play();
        yield return new WaitForSeconds(2f);
        lightpanels[1].SetActive(true);
        sources[3].Play();
        yield return new WaitForSeconds(4f);
        lightpanels[2].SetActive(true);
        sources[3].Play();
        yield return new WaitForSeconds(4f);
    }
    IEnumerator eyesEnuerator() {
        eyesObject[0].SetActive(true);
        yield return new WaitForSeconds(2f);
        eyesObject[1].SetActive(true);
        yield return new WaitForSeconds(4f);
        eyesObject[2].SetActive(true);
        yield return new WaitForSeconds(4f);
    }

}
