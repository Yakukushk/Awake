using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Triggers : MonoBehaviour
{
    public GameObject loadingGame;
    public Slider slider;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            StartCoroutine(LoadLevel(2));
        }
    }
    IEnumerator LoadLevel(int index)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);
        loadingGame.SetActive(loadingGame);
        while (asyncOperation.isDone == false)
        {
            float progress = Mathf.Clamp01(asyncOperation.progress / 0.9f);
            Debug.Log(asyncOperation.progress);
            slider.value = progress;
            yield return null;

        }
    }
}
