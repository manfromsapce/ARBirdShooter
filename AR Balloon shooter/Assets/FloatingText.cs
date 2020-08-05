using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    public GameObject arCam;
    public GameObject FloatingTextPrefab;
    public GameObject FloatingTextPrefab1;
    public GameObject FloatingTextPrefab2;
    
    public void Shooting()
    {

        RaycastHit hit;
        
        if (Physics.Raycast(arCam.transform.position, arCam.transform.forward, out hit))
        {
            if (hit.transform.name == "balloon1(Clone)")
            {
                Instantiate(FloatingTextPrefab1, hit.point, Quaternion.identity);
            }
                if (hit.transform.name == "balloon2(Clone)")
                {
                    Instantiate(FloatingTextPrefab, hit.point, Quaternion.identity);
                }
                    if (hit.transform.name == "balloon3(Clone)")
                    {
                        Instantiate(FloatingTextPrefab2, hit.point, Quaternion.identity);
                    }
            
            


            {
               
               
                


                       
                    
                  
                


               

            }



        }
    }


}
