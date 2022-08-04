using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;



public class Post : MonoBehaviour
{

    public Volume volume;
    public AudioSource[] sources = new AudioSource[3];
    ChromaticAberration chromaticAberration;
    FilmGrain filmGrain;
    bool sourceActive = true;
    

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
            Debug.Log("Changed");
        }
    }

}
