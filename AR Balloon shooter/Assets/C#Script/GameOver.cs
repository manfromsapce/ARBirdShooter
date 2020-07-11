using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject arCam;
    public GameObject smoke;


    public void Loadscene(string SceneName)
    {

        RaycastHit hit;

        if (Physics.Raycast(arCam.transform.position, arCam.transform.forward, out hit))
        {
            if (hit.transform.name == "balloon4(Clone)" || hit.transform.name == "balloon5(Clone)")
            {
               

                {
                    SceneManager.LoadScene(SceneName);
                }

            }



        }
    }
}
