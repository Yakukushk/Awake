using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

interface NewInterface {
    public void LightsPrefabs();
   
   
    
}
public class TVs : MonoBehaviour, NewInterface
{
    public List<Light> LightgameObjects = new List<Light>(5);
    public GameObject[] TriggerPrefabs;
    private bool isActiveLight = false;
    public float[] dist;
    public float mindist = 100f;
   

    void Update() {
        LightsPrefabs();
    }
    public void LightsPrefabs() {
        dist[0] = Vector3.Distance(TriggerPrefabs[0].gameObject.transform.position, gameObject.transform.position);
        dist[1] = Vector3.Distance(TriggerPrefabs[1].gameObject.transform.position, gameObject.transform.position);
        dist[2] = Vector3.Distance(TriggerPrefabs[2].gameObject.transform.position, gameObject.transform.position);
        if (mindist >= dist[0] )
        {
            if (isActiveLight)
            {
                for (var i = 0; i < LightgameObjects.Count; i++)
                {
                    LightgameObjects[i].enabled = false;
                }
            }
            else
            {
                for (var i = 0; i < LightgameObjects.Count; i++)
                {
                    LightgameObjects[i].enabled = true;
                }
            }
        }
        else {
            for (var i = 0; i < LightgameObjects.Count; i++) {
                LightgameObjects[i].enabled = false;
            }
            
        }
    }
    
}
