using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatorText : MonoBehaviour
{
    public Text text;
    string textStory;

    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<Text>();
        textStory = text.text;
        text.text = "";
        StartCoroutine(PlayText());
    }

    // Update is called once per frame
    
    public IEnumerator PlayText()
    {
        foreach (var c in textStory)
        {
            text.text += c;
            yield return new WaitForSeconds(0.125f);
        }
    }
}
