using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebcamDelay;
using SimpleVAS;

public class ApplyRandomDelays : MonoBehaviour {

	public WebcamDisplay webcam;
	public RandomNonRepeat delayRandomizer;

    public static float conditionDelayTime;
	// Use this for initialization
	void Start () {
		
		float timeStepSeconds = BasicDataConfigurations.stepDelay / 1000f;

		if (delayRandomizer != null) {
			int randomizer = delayRandomizer.RandomItemFromList ();
			webcam.delayTimeSeconds = randomizer * timeStepSeconds;
            //Debug.Log ("the current delay time is " + webcam.delayTimeSeconds);

            conditionDelayTime = randomizer * timeStepSeconds;
		}

		else 	webcam.delayTimeSeconds = 0;
	}

}
