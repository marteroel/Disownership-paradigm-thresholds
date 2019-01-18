using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SimpleVAS;

namespace SimpleVAS
{
	public class QuestionManager : MonoBehaviour {

		List<string> questionList = new List<string>();

		public Text questionUI;
		public Button nextButton;
		public Scrollbar scrollValue;

		public CsvWrite csvWriter;

		public bool isForcedChoice;
		public ToggleGroup toggleGroup;

		public static string questionnaireItem, VASvalue;

		private int currentItem;

		public static int currentCondition;

		// Use this for initialization
		void Start () {

			currentItem = 0;
			questionList = CsvRead.questionnaireInput;
			questionUI.text = questionList[currentItem];
			nextButton.interactable = false;

		}
			
		public void OnSelection(){
			
			nextButton.interactable = true;

		}


		public void OnNextButton() {
		
			nextButton.interactable = false;
			questionnaireItem = currentItem.ToString ();
			if (!isForcedChoice)
				VASvalue = scrollValue.value.ToString ();
			else {
				VASvalue = SelectedToggle.activeToggle.ToString ();
				toggleGroup.SetAllTogglesOff ();
			}
			csvWriter.onNextButtonPressed ();

			if (scrollValue != null)
				scrollValue.GetComponent<Scrollbar>().handleRect.gameObject.SetActive(false);
				//gameObject.SetActive(false);

			currentItem ++;

			if (currentItem < questionList.Count) 
				questionUI.text = questionList [currentItem];


			else if (currentItem == questionList.Count) {
				currentItem = 0;
				questionList.Clear();


				if (isForcedChoice) 
						SceneManager.LoadScene ("VAS");

				else {
					currentCondition = currentCondition + 1;

					if (currentCondition < ConditionDictionary.selectedOrder.Length)
						SceneManager.LoadScene ("Inter");
					else if (currentCondition == ConditionDictionary.selectedOrder.Length)
						SceneManager.LoadScene ("Goodbye");
				}
			}
		}
	}
}
