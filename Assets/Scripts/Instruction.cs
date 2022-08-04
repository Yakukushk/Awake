using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    public GameObject instruction;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            instruction.SetActive(instruction);
            Debug.Log(instruction.activeSelf);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            instruction.SetActive(!instruction);
            Debug.Log(instruction.activeSelf);
        }
    }
}
