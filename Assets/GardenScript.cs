using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenScript : MonoBehaviour
{
    public Light[] lights;
    public GameObject terrain;
    public GameObject Eye;
    public GameObject wall;
    bool isEnter = false;
    public Light DirectionLight;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (isEnter)
            {
                for (var i = 0; i < lights.Length; i++)
                {
                    lights[i].enabled = false;
                }
            }
            else
            {
               
                for (var i = 0; i < lights.Length; i++)
                {
                    lights[i].enabled = true;
                }
                terrain.SetActive(false);
                Eye.SetActive(false);
                wall.SetActive(true);
              //  DirectionLight.intensity = 0.5988619f;
            }
        }
        else {
            for (var i = 0; i < lights.Length; i++)
            {
                lights[i].enabled = false;
            }
        }
    }
}
