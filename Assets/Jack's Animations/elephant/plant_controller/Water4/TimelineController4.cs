using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController4 : MonoBehaviour
{
    public PlayableDirector playableDirector;

    public void Play(){
        playableDirector.Play();
    }
}
