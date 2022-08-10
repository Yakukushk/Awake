using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Demo : MonoBehaviour
{
    public TextMeshPro textMesh;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        textMesh.enabled = true;
        StartCoroutine(enumerator());
        Debug.Log("Collider");
    }

    IEnumerator enumerator() {
        Application.Quit();
        Debug.Log("Exit");
        yield return new WaitForSeconds(3f);
    }
}
