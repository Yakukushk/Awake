using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IMessages {
     void Mapping();
}
public class FairyPoint : MonoBehaviour, IMessages
{
    [SerializeField] private GameObject target = null;
    [SerializeField] private GameObject Hero = null;
    [SerializeField] private float speed = 15f;
    [SerializeField] private float dist = 0.0f;
    [SerializeField] private float mindist = 5.0f;
    [SerializeField] private bool isDistance = false;
    private Rigidbody rigidbody_;
    [SerializeField] private float rotatioSpeed = 3f;
    [SerializeField] private float positionSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody_.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Mapping();
    }
    public void Mapping() {
        dist = Vector3.Distance(Hero.gameObject.transform.position, gameObject.transform.position );
        if (dist <= mindist) {
            if (isDistance)
            {
                string txt = "Error";
                Debug.Log(txt);
            }
            else {
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
                transform.up = transform.position - target.transform.position;
                rigidbody_.AddRelativeForce(0f, 0f, 0f);
                rigidbody_.AddRelativeTorque(0f, 0f, 0f);
            }
        }
    }
}
