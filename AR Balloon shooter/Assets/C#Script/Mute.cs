using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    bool isMute;

    public void mute()
    {
        //isMute = !isMute;
        //AudioListener.volume = isMute ? 0 : 1;
        AudioListener.pause = !AudioListener.pause;
    }
}
