using System.Collections;
using System.Collections.Generic;
using UnityEngine;
interface MannequinsMessage {
    void DistanceObject();
    void RotationObject();
}
public class ManenequinsScript : MonoBehaviour, MannequinsMessage
{
    // for distance obj
    public GameObject PointA = null;
    public GameObject PointB = null;
    private bool isDistance_ = false;
    public float mindist = 30f;
    public float dist = 0.0f;

    // for rotation obj
    public Transform target = null;
    private bool isRotation_ = false;
    public float speed = 5f;

    void Update() {


        DistanceObject();


    }
    public void DistanceObject() {
        dist = Vector3.Distance(PointA.transform.position, PointB.transform.position);
        if (mindist >= dist)
        {
            if (isDistance_)
            {
                string txt = "Error";
                Debug.Log(txt);
            }
            else
            {
                RotationObject();
            }
        }
       
    }
    public void RotationObject() {
        if (isRotation_) {
            string txt = "Error";
            Debug.Log(txt);
        } 
         else {
            Vector3 direction = target.position - transform.position;
            Quaternion quaternion = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, quaternion, speed * Time.deltaTime);
          }
    }
}
