using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissedTrialInput : MonoBehaviour {

    public static string missedTrial;

    public static MissedTrialInput instance;

    // Use this for initialization
    void Start () {
        missedTrial = "NA";
	}
	
	// Update is called once per frame
	void Update () {	
        if(Input.GetMouseButtonDown(2)){
            missedTrial = "missed";
        }
	}
}
