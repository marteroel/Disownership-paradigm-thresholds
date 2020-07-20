using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebcamDelay;
using SimpleVAS;

public class ApplyRandomDelays : MonoBehaviour {

	public WebcamDisplay webcam;

	public static float conditionDelayTime;

	// Use this for initialization
	void Start () {
		
		float timeStepSeconds = BasicDataConfigurations.stepDelay / 1000f;

			int randomizer = RandomNonRepeat.instance.RandomItemFromList ();
			webcam.delayTimeSeconds = randomizer * timeStepSeconds;
			//Debug.Log ("the current delay time is " + delayTimeSeconds);

			conditionDelayTime = randomizer * timeStepSeconds;
	}

}
