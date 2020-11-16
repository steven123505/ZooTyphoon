using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController5 : MonoBehaviour
{
    public PlayableDirector playableDirector;

    public void Play(){
        playableDirector.Play();
    }
}
