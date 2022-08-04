using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    public GameObject loadingGame;
    public Slider slider;
   public void StartGame(int index) {
        StartCoroutine(LoadLevel(index));
    }
    IEnumerator LoadLevel(int index) {
      AsyncOperation asyncOperation =  SceneManager.LoadSceneAsync(index);
        loadingGame.SetActive(loadingGame);
        while (asyncOperation.isDone == false) {
            float progress = Mathf.Clamp01(asyncOperation.progress / 0.9f);
            Debug.Log(asyncOperation.progress);
            slider.value = progress;
            yield return null;

        }
    }
    public void QuitGame() {
        Application.Quit();
    }
}
