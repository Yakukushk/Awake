using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoCollider : MonoBehaviour
{
    public VideoPlayer videoPlayer;

  


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            videoPlayer.enabled = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            gameObject.SetActive(false);
        }
    }
    private void Update()
    {
       
    }
}
