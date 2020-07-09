using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebcamUI : MonoBehaviour {

	public RawImage display;
	public Dropdown webcamSelector;

	// Use this for initialization
	void Start () {

		webcamSelector.value = PlayerPrefs.GetInt ("selectedCamera");
		SetWebCamOptions ();
		SelectWebcam ();

	}

	public void SetWebCamOptions(){
		webcamSelector.options.Clear ();

		List<string> devices = new List<string> ();

		foreach (var item in WebCamTexture.devices) {
			devices.Add(item.name);
		}


		webcamSelector.AddOptions (devices);
	}

	public void SelectWebcam () {

        Webcam.instance.SelectWebcam(webcamSelector.value);

        if (Webcam.instance.webcamTexture != null)
            display.texture = Webcam.instance.webcamTexture;
    }


	void OnDestroy(){
		PlayerPrefs.SetInt ("selectedCamera", webcamSelector.value);

	}
}
