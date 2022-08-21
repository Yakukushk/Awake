using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public Animator animator;
    public GameObject SettingsPanel;
    [SerializeField] private bool SettingsBool;
    //public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        GetTransform = gameObject.transform;
        GetTransform = GetComponent<Transform>();
      //  GetTransform.localScale = new Vector3(2f, 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        FlashLigth();
        Settings();
       
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
        
        void Bobbing() {
            if (Input.GetKeyDown(KeyCode.W))
            {
                animator.SetTrigger("bob");
                animator.ResetTrigger("stop");
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                animator.SetTrigger("stop");
                animator.ResetTrigger("bob");
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                animator.SetTrigger("bob");
                animator.ResetTrigger("stop");
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                animator.SetTrigger("stop");
                animator.ResetTrigger("bob");
            }
        }
    void Settings()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SettingsPanel.activeSelf == false)
            {
                SettingsPanel.SetActive(true);
                Cursor.lockState = CursorLockMode.Confined;
                audioSources[0].enabled = false;
                audioSources[1].enabled = false;

                Time.timeScale = 0;
            }
            else {

                SettingsPanel.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                audioSources[0].enabled = true;
                audioSources[1].enabled = true;

                Time.timeScale = 1;
                }
        }
    }
    }

