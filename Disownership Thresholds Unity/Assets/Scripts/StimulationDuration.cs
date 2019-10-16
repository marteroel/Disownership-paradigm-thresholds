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

        StartCoroutine ("ChangeSceneAtTime");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator ChangeSceneAtTime (){

		yield return new WaitForFixedTime (stimulationTime);
		screenOff.SetActive (true); //turns off screen 
		SceneManager.LoadScene(sceneToLoad);
		webcam.TurnOff ();

	}
}
