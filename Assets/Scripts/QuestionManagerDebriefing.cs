using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SimpleVAS;

namespace SimpleVAS
{
    public class QuestionManagerDebriefing : MonoBehaviour
    {

        List<string> questionList = new List<string>();

        public Text questionUI;
        public Button nextButton;
        public Scrollbar scrollValue;

        public CsvWrite csvWriter;

        private int currentItem;

        // Use this for initialization
        void Start()
        {
            currentItem = 0;
            questionList = CsvRead.questionnaireInput;
            questionUI.text = questionList[currentItem];
            nextButton.interactable = false;

            QuestionManager.conditionTouchOrMove = "NA";

        }

        public void OnSelection()
        {
            nextButton.interactable = true;
        }


        public void OnNextButton()
        {
            nextButton.interactable = false;
            QuestionManager.questionnaireItem = currentItem.ToString();

            QuestionManager.VASvalue = scrollValue.value.ToString();
            
            csvWriter.onNextButtonPressed();

            if (scrollValue != null)
                scrollValue.GetComponent<Scrollbar>().handleRect.gameObject.SetActive(false);

            currentItem++;

            if (currentItem < questionList.Count)
                questionUI.text = questionList[currentItem];

            else if (currentItem == questionList.Count)
            {
                currentItem = 0;
                questionList.Clear();

                SceneManager.LoadScene("Goodbye");

            }
        }
    }
}
