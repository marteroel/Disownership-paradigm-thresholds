using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonitorControllerMovement : MonoBehaviour {

	public Text text;
	//private HandTracking _handtracking;
	// Use this for initialization

	void Start () {
		//_handtracking = HandTracking.instance;	
	}
	
	// Update is called once per frame
	void Update () {
		text.text = HandTracking.instance._accel.ToString ();
	}
}
