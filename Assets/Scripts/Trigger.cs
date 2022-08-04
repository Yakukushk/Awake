using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class Trigger : MonoBehaviour
{
    public GameObject trigger;
    public GameObject triggerNote;
 

    void Start()
    {
        
    }
   void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            triggerNote.SetActive(triggerNote);
            Debug.Log(triggerNote.activeSelf);
           // Time.timeScale = 0f;

        }
        
        // Debug.Log("Entered");

    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        triggerNote.SetActive(!triggerNote);
        Debug.Log(triggerNote.activeSelf);
       // Time.timeScale = 1f;
    }
    private void Update()
    {
       // Book();
        
    }
    void Book() {
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            if (triggerNote.activeSelf == false)
            {
                triggerNote.SetActive(triggerNote);
                Debug.Log(triggerNote.activeSelf);
                Time.timeScale = 0f;
            }
            else
            {
                triggerNote.SetActive(!triggerNote);
                Debug.Log(triggerNote.activeSelf);
                Time.timeScale = 1f;
            }
        }
    }


}
