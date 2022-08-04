using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bedroom : MonoBehaviour
{
    public GameObject triggerNote;
    public GameObject Lamp;
    public GameObject system;
    public GameObject Ligth;
    public Animator animation;
    public GameObject collideR;
    public AudioSource source;
    public Light[] ligths;
    public GameObject[] wallls = new GameObject[2];
    FixedJoint joint;
    Rigidbody rb;
    // Start is called before the first frame update
     void Start()
    {
        rb = GetComponent<Rigidbody>();
        //system = transform.GetComponent<ParticleSystem>();
        rb.mass = 30f;
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            triggerNote.SetActive(triggerNote);
            Debug.Log(triggerNote.activeSelf);
            // Time.timeScale = 0f;

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            triggerNote.SetActive(!triggerNote);
            joint = Lamp.AddComponent<FixedJoint>();
            rb = Lamp.AddComponent<Rigidbody>();
            system.SetActive(true);
            source.Play();
            // Instantiate(system, transform.position, Quaternion.identity);
            // system.transform.position = new Vector3(-0.05560494f, -1.082f, 03999997f);
            Ligth.SetActive(!Ligth);
            collideR.SetActive(collideR);
            wallls[0].SetActive(!wallls[0]);
            wallls[1].SetActive(wallls[0]);
            ligths[0].enabled = false;
            ligths[1].enabled = false;
          
            animation.SetBool("Play", true);
            
        }
    }



}
