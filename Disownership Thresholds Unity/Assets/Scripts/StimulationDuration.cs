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

	// Use this for initialization
	void Start () {
        StartCoroutine("WaitBeforeShowingCameraFeed");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator WaitBeforeShowingCameraFeed()
    {
        yield return new WaitForFixedTime(1f);
        screenOff.SetActive(false);
        StartCoroutine("ChangeSceneAtTime");
    }

	private IEnumerator ChangeSceneAtTime (){

		yield return new WaitForFixedTime (BasicDataConfigurations.trialDuration);
		screenOff.SetActive (true); //turns off screen 
		SceneManager.LoadScene(sceneToLoad);
		webcam.TurnOff ();

	}
}
