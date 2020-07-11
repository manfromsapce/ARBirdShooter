using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject arCam;
    public GameObject smoke;


    public void Shoot() {

        RaycastHit hit;

        if (Physics.Raycast(arCam.transform.position, arCam.transform.forward, out hit)) {
            if (hit.transform.name == "balloon1(Clone)" || hit.transform.name == "balloon2(Clone)" || hit.transform.name == "balloon3(Clone)" || hit.transform.name == "balloon4(Clone)" || hit.transform.name == "balloon5(Clone)")
            {

                Destroy(hit.transform.gameObject);

                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

                ScoreScript.scoreValue += 10;
                
            }
          


        }
    }


}
