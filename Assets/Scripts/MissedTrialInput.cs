using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissedTrialInput : MonoBehaviour {

    [HideInInspector]
    public string missedTrial;

    public static MissedTrialInput instance;

    private void Awake()
    {
        if (instance == null) instance = this;
    }

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
