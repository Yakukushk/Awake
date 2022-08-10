using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    float speed = 5f;
    float fastspeed = 10f;
    public CharacterController controller;
    float gravity = -9.81f;
    Vector3 velocity;
    public GameObject flashligth;
    public Transform GetTransform;
    public AudioSource[] audioSources = new AudioSource[2];
    //public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        GetTransform = gameObject.transform;
        GetTransform = GetComponent<Transform>();
        GetTransform.localScale = new Vector3(2f, 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        FlashLigth();
       
    }
    void Move() {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        
     
    }
    void FlashLigth() {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (flashligth.activeSelf == false)
            {
                flashligth.SetActive(flashligth);
                Debug.Log("Active -> " + flashligth.activeInHierarchy);
                audioSources[0].Play();
            }
            else {
                flashligth.SetActive(!flashligth);
                audioSources[1].Play();
            }
        }
       
        

    }
}
