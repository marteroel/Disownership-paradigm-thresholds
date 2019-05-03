using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
using System.IO.Ports;

namespace SimpleVAS {
	public class BasicDataConfigurations : MonoBehaviour {

		public InputField nameField, ageField, trialDurationField, stepRepetitionsField, numberOfStepsField, stepDelayField;//added  trialDurationField, stepRepetitionsField, numberOfStepsField, stepDelayField
		public Text genderField, handednessField;
		public Button nextButton;
		public Toggle calibrationToggle;
        //added
        public Dropdown webcamDevice, conditionInput;
		public static string ID, age, gender, handedness, condition;
		public static bool useCalibration;
		//added
		public static int selectedWebcamDevice, stepRepetitions, numberOfSteps, stepDelay;
		public static float trialDuration;

		// Use this for initialization
		void Start () {

			nextButton.interactable = false;
			//SetSerialDropDownOptions ();

			trialDurationField.text = PlayerPrefs.GetFloat("condition duration").ToString();
			stepRepetitionsField.text = PlayerPrefs.GetInt("step repetitions").ToString();
			numberOfStepsField.text = PlayerPrefs.GetInt("number of steps").ToString();
			stepDelayField.text = PlayerPrefs.GetInt("delay per step").ToString();
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


			trialDuration = float.Parse (trialDurationField.text);
			stepRepetitions = int.Parse (stepRepetitionsField.text);
			numberOfSteps = int.Parse (numberOfStepsField.text);
			stepDelay = int.Parse (stepDelayField.text);

            condition = conditionInput.options[conditionInput.value].text;

			Debug.Log ("the duration is " + trialDuration +  " repetitions " + stepRepetitions + " steps " + " and the the delay is " + stepDelay);
			storePreferences ();
		}

		//added
		private void storePreferences(){
			

			PlayerPrefs.SetFloat ("condition duration", trialDuration);
			PlayerPrefs.SetInt ("step repetitions", stepRepetitions);
			PlayerPrefs.SetInt ("number of steps", numberOfSteps);
			PlayerPrefs.SetInt ("delay per step", stepDelay);



		}

	

	}

}