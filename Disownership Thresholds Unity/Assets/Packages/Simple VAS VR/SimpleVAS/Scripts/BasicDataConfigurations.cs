using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
using System.IO.Ports;

namespace SimpleVAS {
	public class BasicDataConfigurations : MonoBehaviour {

		public InputField nameField, ageField, conditionDurationField;//added  conditionDurationField, threatTimeField
		public Text genderField, handednessField;
		public Button nextButton;
		public Toggle calibrationToggle;
		//added
		public Dropdown webcamDevice;
		public static string ID, age, gender, handedness, conditionOrder;
		public static bool useCalibration;
		//added
		public static int selectedWebcamDevice;
		public static float conditionDuration;

		// Use this for initialization
		void Start () {
			nextButton.interactable = false;
			//SetSerialDropDownOptions ();

			conditionDurationField.text = PlayerPrefs.GetFloat("condition duration").ToString();

		}
		
		// Update is called once per frame
		void Update () {
			if (ID != null && age != null)
				nextButton.interactable = true;
		}

		public void userName() {
			ID = nameField.text;
		}

		public void userAge() {
			age = ageField.text;
		}

		public void OnNextButton () {

			gender = genderField.text;
			handedness = handednessField.text;
			useCalibration = calibrationToggle.isOn;

			//added
			selectedWebcamDevice = webcamDevice.value;


			conditionDuration = float.Parse (conditionDurationField.text);


			storePreferences ();
		}

		//added
		private void storePreferences(){
			

			PlayerPrefs.SetFloat ("condition duration", conditionDuration);


		}

	

	}

}