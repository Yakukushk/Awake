using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPassword : MonoBehaviour
{
    public GameObject[] gameObjects = new GameObject[2];
    public AudioSource[] sources = new AudioSource[2];
    public CameraController cameraController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            gameObjects[0].SetActive(true);
            gameObjects[1].SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
            sources[0].enabled = false;
            sources[1].enabled = false;
            cameraController.enabled = false;

            Debug.Log(gameObjects[0].activeSelf);
            Debug.Log(gameObjects[1].activeSelf);

           
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            gameObjects[0].SetActive(false);
            gameObjects[1].SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            sources[0].enabled = true;
            sources[1].enabled = true;
            cameraController.enabled = true;

            Debug.Log(gameObjects[0].activeSelf);
            Debug.Log(gameObjects[1].activeSelf);
        }
    }
}
