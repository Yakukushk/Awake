using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    public GameObject instruction;
    [SerializeField] private bool instructionbool = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            if (instructionbool)
            {
                instruction.SetActive(instruction);
                gameObject.SetActive(true);
                Debug.Log(instruction.activeSelf);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            instruction.SetActive(!instruction);
            gameObject.SetActive(false);
            Debug.Log(instruction.activeSelf);
        }
    }
}
