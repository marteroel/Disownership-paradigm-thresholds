using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAudioSource : MonoBehaviour
{

    public AudioSource _audio;
    private float _initialVolume;

    public static FadeAudioSource instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;

        _initialVolume = _audio.volume;
    }

    public void FadeIn(){
        StartCoroutine(StartFade(_audio, 1f, _initialVolume));
    }

    public void FadeOut(){
        StartCoroutine(StartFade(_audio, 1f, 0));
    }


    private IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = audioSource.volume;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }
}

