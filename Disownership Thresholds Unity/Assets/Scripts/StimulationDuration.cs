using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleVAS;
using WebcamDelay;
using UnityEngine.SceneManagement;

public class StimulationDuration : MonoBehaviour {

	public GameObject screenOff;
	public string sceneToLoad;
	public WebcamDisplay webcam;

    private float stimulationTime;

    // Use this for initialization
    void Start () {
		screenOff.SetActive (false);
        stimulationTime = BasicDataConfigurations.trialDuration + webcam.delayTimeSeconds;

        //Debug.Log("Time scale: " + Time.timeScale);
        //Debug.Log("Fixed Unscaled Time 1: " + Time.fixedUnscaledTime);
        //Debug.Log("Fixed time 1: " + Time.fixedTime);
        //Debug.Log("Time to wait: " + BasicDataConfigurations.trialDuration + " + " + webcam.delayTimeSeconds + " = " + stimulationTime);
        StartCoroutine ("ChangeSceneAtTime");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator ChangeSceneAtTime (){

		yield return new WaitForSecondsRealtime(stimulationTime);
        //Debug.Log("Fixed Unscaled Time 2: " + Time.fixedUnscaledTime);
        //Debug.Log("Fixed time 2: " + Time.fixedTime);
        screenOff.SetActive (true); //turns off screen 
		SceneManager.LoadScene(sceneToLoad);
		webcam.TurnOff ();

	}
}
