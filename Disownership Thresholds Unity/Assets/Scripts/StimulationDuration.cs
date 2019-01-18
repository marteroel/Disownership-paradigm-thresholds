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
		screenOff.SetActive (false);
		StartCoroutine ("ChangeSceneAtTime");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator ChangeSceneAtTime (){

		yield return new WaitForFixedTime (10f);
		screenOff.SetActive (true); //turns off screen 
		SceneManager.LoadScene(sceneToLoad);
		webcam.TurnOff ();

	}
}
