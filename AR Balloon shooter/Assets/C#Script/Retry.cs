using System.Collections;
using System.Collections.Generic;
//using System.Runtime.Hosting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Retry : MonoBehaviour
{
    public void LoadScene(string SceneName)

    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneName);
        ScoreScript.scoreValue = 0;



    }


}
