using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text text;
 
    [TextArea(3,10)]
    public string[] lines;
    public float textspeed;
    private int Index;

    void Start()
    {
        text.text = string.Empty;
        StartDialogue();
    }

    public void StartDialogue() {
        Index = 0;
       
        
        StartCoroutine(TypeLine());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (text.text == lines[Index])
            {
                NextDialogue();
            }
            else
            {
                StopAllCoroutines();
                text.text = lines[Index];
            }
        }
    }
    IEnumerator TypeLine() {
        foreach (var item in lines[Index].ToCharArray()) {
            text.text += item;
            yield return new WaitForSeconds(textspeed);
        }
    }
    public void NextDialogue() {
        if (Index < lines.Length - 1)
        {
            Index++;
            text.text = string.Empty;
            StartCoroutine(TypeLine());
           
        }
        else {
            gameObject.SetActive(false);
           

        }
    }
}
