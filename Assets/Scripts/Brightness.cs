using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class Brightness : MonoBehaviour
{
    [SerializeField] private float mindist = 2f;
    [SerializeField] private float dist = 0.0f;
    [SerializeField] private bool SceneBool = false;
    [SerializeField] private Text text;
    public GameObject Tv;

    private void Update()
    {
        Distance();
        Print();
    }

    void Distance() {
        dist = Vector3.Distance(Tv.gameObject.transform.position, gameObject.transform.position);

        if (dist <= mindist)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (SceneBool)
                {
                    SceneBool = false;

                }
                else
                {
                    SceneBool = true;
                    SceneManager.LoadScene(0);

                }
            }
        }
        else {
            SceneBool = false;
        }
    }
    void Print() {
        if (mindist >= dist) {
            text.enabled = true;
        }
    }
}
