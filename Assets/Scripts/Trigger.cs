using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class Trigger : MonoBehaviour
{
    public GameObject[] games = new GameObject[2];
    public Text text;
    public GameObject[] Notes = new GameObject[2];
    public float mindist = 5f;
    public float dist;
    public float dist1;
    bool readingfornote1 = false;
    bool readingfornote2 = false;


    private void Update()
    {
       Reading();
       Print();
       Reading1();
        
    }
    void Reading() {
        dist = Vector3.Distance(games[0].gameObject.transform.position, gameObject.transform.position);
       
        
        
        if (dist <= mindist) {
           

            if (Input.GetKeyDown(KeyCode.E))
            {
                text.enabled = false;
                if (readingfornote1)
                {
                    readingfornote1 = false;
                    Notes[0].SetActive(false);
                    //text.enabled = false;

                    Debug.Log("Close");

                }
                else
                {
                    readingfornote1 = true;
                    Notes[0].SetActive(true);
                  //  text.enabled = false;
                    Debug.Log("Open");
                }
            }
           
        }
        else
        {
            readingfornote1 = false;
          //  text.enabled = true;
            Notes[0].SetActive(false);

        }
       
    }
    void Reading1() {
         dist1 = Vector3.Distance(games[1].gameObject.transform.position, gameObject.transform.position);
        if (dist1 <= mindist)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (readingfornote2)
                {
                    readingfornote2 = false;
                    Notes[1].SetActive(false);

                }
                else
                {
                    readingfornote2 = true;
                    Notes[1].SetActive(true);
                }
            }

        }
        else
        {
            readingfornote2 = false;
            Notes[1].SetActive(false);

        }
    }

    void Print() {
        if (dist <= mindist || dist1 <= mindist)
        {
            string txt = "Press E";
            text.enabled = true;
            text.text = txt;
        }
        else {
            text.enabled = false;
        }

    }

}
