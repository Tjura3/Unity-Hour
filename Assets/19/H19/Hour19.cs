using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Hour19 : MonoBehaviour
{
   
    PlayableDirector director;
    void Start()
    {
        director = GetComponent<PlayableDirector>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (director.state == PlayState.Paused)
                director.Play();
            else
                director.Stop();
        }
    }


}
