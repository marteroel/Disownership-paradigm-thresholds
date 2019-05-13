using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleVAS;

public class RandomNonRepeat : MonoBehaviour { 

	private static List<int> possibleItems = new List<int>();

	public int possibleValues;
	public int repetitionPerValue;

	private int selectedItem;
	public static bool isOver = false;
	private static bool onStart = false;

	void Awake () {
		
		possibleValues = BasicDataConfigurations.numberOfSteps;
		repetitionPerValue = BasicDataConfigurations.stepRepetitions;

		DontDestroyOnLoad (this);

		if (onStart == false) {
			for (int i = 0; i < possibleValues; i++) {
				for (int b = 1; b <= repetitionPerValue; b++) {
					possibleItems.Add (i);
				}
				onStart = true; //there may be a better way, this is so that it only fills the list the first time this script is called.
			}
		}

		for (int i = 0; i < possibleItems.Count; i++) {
			//Debug.Log ("The possible values in the list are " + possibleItems [i]);
		}
	}


	public int RandomItemFromList (){ // should be corrected to do this -1 time.

		if (possibleItems.Count > 1) {	

			Debug.Log("the current count: " + possibleItems.Count);
			int randomIndex = Random.Range (0, possibleItems.Count);
			int selectedItem = possibleItems [randomIndex];
			possibleItems.RemoveAt (randomIndex);
            //Debug.Log ("took the item " + selectedItem);

            return selectedItem;
            
		} 

		else {

			int randomIndex = Random.Range (0, possibleItems.Count);
			int selectedItem = possibleItems [randomIndex];
			possibleItems.RemoveAt (randomIndex);
			isOver = true;

            return selectedItem;
		}
	}

}
