using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Radio : MonoBehaviour {

    public List<AudioClip> songs = new List<AudioClip>();
    
    AudioSource _audioSource;

    void Start()
    {
        _audioSource = Harmony.SetSource(songs[1].ToString());

        /*
        Harmony.EnabledPlayList(_audioSource, true);

        Harmony.AddClip(_audioSource, songs[1]);

        Harmony.EnabledPlaylistLoop(_audioSource, true);
        */

    }


    //Radio Kill the Video Star

	void Play()
    {
        Harmony.Play(_audioSource, true);
    }

    void Pause()
    {
        Harmony.Pause(_audioSource);
    }

    void UnPause()
    {
        Harmony.UnPause(_audioSource);
    }

    void Stop()
    {
        Harmony.Stop(_audioSource);
    }

    void Next()
    {
        Harmony.NextClip(_audioSource);
    }

    void Previous()
    {
        Harmony.PreviousClip(_audioSource);
    }

}
