using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CodePanel : MonoBehaviour
{
    [SerializeField]
    public Text text;
    string codeValue = "";
    public GameObject[] doors = new GameObject[2];
    public AudioSource[] sources = new AudioSource[3];
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = codeValue;
       // text.text = string.Empty;
        if (codeValue == "1324") {
            doors[0].SetActive(false);
            doors[1].SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            gameObject.SetActive(false);
            sources[1].Play();
            sources[2].Stop();
        }
        
        if (codeValue != "1324" && codeValue.Length >= 4) {
            sources[0].Play();
        }
        if (codeValue.Length >= 4) {
            codeValue = "";
        }
    }

    public void AddDigit(string digit) {
        codeValue += digit; 
    }
}
