using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageFades : MonoBehaviour {

    public bool inOnStart;
    
	// Use this for initialization
	void Start () {

        if (!FadeAudioSource.instance._audio.isPlaying) {
            FadeAudioSource.instance._audio.volume = 0;
            FadeAudioSource.instance._audio.Play();
        }

        if (!inOnStart)
            FadeAudioSource.instance.FadeOut();
        else
            FadeAudioSource.instance.FadeIn();
    }
	
	// Update is called once per frame
	void OnDestroy () {
        if (!inOnStart)
            FadeAudioSource.instance.FadeIn();
        else
            FadeAudioSource.instance.FadeOut();
    }
}
