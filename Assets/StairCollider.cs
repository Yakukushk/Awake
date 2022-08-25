using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairCollider : MonoBehaviour
{
    //Vector3(-32.7999992,-43.9781189,-97.9580536)
    //[SerializeField] private Animator animator = null;
    [SerializeField] private bool isEnter_ = false;
    [SerializeField] private GameObject stair = null;
    [SerializeField] private GameObject PointA = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            if (isEnter_)
            {
                string txt = "Stay";
                Debug.Log(txt);
                stair.transform.position = new Vector3(-32.7999992f, -43.9781189f, -97.9580536f);
            }
            else {
                string txt = "Move";
                Debug.Log(txt);
                MoveStair();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.SetActive(false);
    }
    void MoveStair() {
        stair.transform.position = Vector3.MoveTowards(stair.transform.position, PointA.transform.position, Time.deltaTime);


    }
}
