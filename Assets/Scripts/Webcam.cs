using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Webcam : MonoBehaviour
{
    [HideInInspector]
    public WebCamTexture webcamTexture;
    public static Webcam instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;

        DontDestroyOnLoad(this);
    }


    public void SelectWebcam(int value)
    {
        if (webcamTexture != null) webcamTexture.Stop();

        WebCamDevice[] devices = WebCamTexture.devices;
        string deviceName = devices[value].name;
        webcamTexture = new WebCamTexture(deviceName, 1024, 768); //WebCamTexture(deviceName, 1024, 768)

        webcamTexture.Play();

    }


    void OnDestroy()
    {
        if (webcamTexture != null) webcamTexture.Stop();

    }
}
