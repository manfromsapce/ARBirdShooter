using System.Collections;
using System.Collections.Generic;
//using System.Runtime.Hosting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    public void Loadscene(string SceneName)

    {
        SceneManager.LoadScene(SceneName);
    }


}
