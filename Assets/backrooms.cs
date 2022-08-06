using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backrooms : MonoBehaviour
{
    [SerializeField] private bool reading = false;
    [SerializeField] private GameObject panel = null;
    [SerializeField] private GameObject book = null;
    [SerializeField] private float dist;
    [SerializeField] private float mindist = 2;
    [SerializeField] private Text text = null;

    // Update is called once per frame
    void Update()
    {
        Reading();
        Print();
    }
    void Reading() {
        dist = Vector3.Distance(book.gameObject.transform.position, gameObject.transform.position);
        if (dist <= mindist)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (reading)
                {
                    reading = false;
                    panel.SetActive(false);
                }
                else
                {
                    reading = true;
                    panel.SetActive(true);
                }
            }

        }
        else {
            reading = false;
            panel.SetActive(false);
        }
    }
    void Print() {
        if (dist <= mindist)
        {
            string txt = "Press E";
            text.text = txt;
            text.enabled = true;
        }
        else {
            text.enabled = false;
        }

    }
}
