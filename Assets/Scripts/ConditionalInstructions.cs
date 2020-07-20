using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleVAS;
using UnityEngine.UI;

public class ConditionalInstructions : MonoBehaviour {

    public Text instructionsA, instructionsB;

	// Use this for initialization
	void Start () {
        //Debug.Log("current condition is : " + QuestionManager.currentCondition);

        if (BasicDataConfigurations.condition == "1")
            if(QuestionManager.currentCondition == 0 | QuestionManager.currentCondition == 2 | QuestionManager.currentCondition == 5 | QuestionManager.currentCondition == 7)
                instructionsA.gameObject.SetActive(true);
        else
            if (QuestionManager.currentCondition == 1 | QuestionManager.currentCondition == 3 | QuestionManager.currentCondition == 4 | QuestionManager.currentCondition == 6)
                instructionsB.gameObject.SetActive(true);
	}
}
