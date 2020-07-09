using System.Collections;
using System.Collections.Generic;
using UnityEngine;  
using SimpleVAS;

namespace WebcamDelay {
	public class WebcamDisplay : MonoBehaviour {

		private WebCamTexture webcamTexture;
		private Texture2D delayedImage;
		ArrayList myBuffer = new ArrayList();

		public bool setDelay;
		public float delayTimeSeconds;
		public int webcamDeviceID;


		void Start () {
			
			//WebCamDevice[] devices = WebCamTexture.devices;
			//string deviceName = devices[BasicDataConfigurations.selectedWebcamDevice].name;
			//webcamTexture = new WebCamTexture(deviceName, 1024, 768);
			
            webcamTexture = Webcam.instance.webcamTexture;
            webcamTexture.Play();
        }
			

		void Update () {
			
			if (webcamTexture.didUpdateThisFrame) {

				if (setDelay) {
					StartCoroutine (ConvertFrame());
					StartCoroutine (DelayWebcam());
				} 

				else if (!setDelay && myBuffer.Count != 0) {
					StopAllCoroutines();
					myBuffer.Clear ();
					Resources.UnloadUnusedAssets ();
				}
			}

		}

		void FixedUpdate () {
			UpdateFrame ();
		}
			

		private void UpdateFrame () {

			if (!setDelay) {
				Renderer renderer = GetComponent<Renderer> ();
				renderer.material.mainTexture = webcamTexture;
			} 

			else if (setDelay) {
				Renderer renderer = GetComponent<Renderer> ();
				renderer.material.mainTexture = delayedImage;
			}

		}

		//Added
		void OnDestroy() {
			//webcamTexture.Stop ();
		}
		//added
		public void TurnOff() {
			//webcamTexture.Stop ();
		}

		IEnumerator ConvertFrame(){

			yield return null;

			Texture2D frame = new Texture2D (webcamTexture.width, webcamTexture.height);
			frame.SetPixels32 (webcamTexture.GetPixels32 ());
			myBuffer.Add (frame);

		}

		IEnumerator DelayWebcam(){

			yield return new WaitForFixedTime (delayTimeSeconds); //custom coroutine

			delayedImage = myBuffer [0] as Texture2D;
			delayedImage.Apply();
			myBuffer.RemoveAt (0);
			Resources.UnloadUnusedAssets ();

		}

			
	}
}