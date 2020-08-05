using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
    
{
    public float DestroyTime;
    public Vector3 RandomizeIntensity = new Vector3(0, 0, 0);



    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyTime);
        transform.localPosition += new Vector3(Random.Range(-RandomizeIntensity.x, RandomizeIntensity.x),
           Random.Range(-RandomizeIntensity.y, RandomizeIntensity.y),
           Random.Range(-RandomizeIntensity.z, RandomizeIntensity.z));





        
        
    }

    
}
