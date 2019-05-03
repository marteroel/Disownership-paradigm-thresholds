using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleVAS;
using UnityEngine.UI;

public class ConditionalInstructions : MonoBehaviour {

    public Text instructionsA, instructionsB;

	// Use this for initialization
	void Start () {
        if (BasicDataConfigurations.condition == "Active movement")
            instructionsA.gameObject.SetActive(true);
        else
            instructionsB.gameObject.SetActive(true);
	}
}
