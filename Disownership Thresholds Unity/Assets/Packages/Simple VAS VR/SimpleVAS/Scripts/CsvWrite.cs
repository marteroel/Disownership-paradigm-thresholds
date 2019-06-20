﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleVAS;
using UnityEngine.SceneManagement;

namespace SimpleVAS 
{
	public class CsvWrite : MonoBehaviour {

		private string condition;
		private static CsvWrite instance = null;
		public static CsvWrite Instance
		{
			get { return instance; }
		}

		//This allows the start function to be called only once.
		void Awake()
		{
			if (instance != null && instance != this) {
				Destroy(this.gameObject);
				return;
			} 
			else 
				instance = this;

			DontDestroyOnLoad(this.gameObject);
		}


		void Start () {
			WriteToFile ("subject ID", "age", "gender", "handedness", "question ID", "questionnaire type", "delay", "condition", "value", "onset", "offset");
		}
			

		public void onNextButtonPressed(){
			if (BasicDataConfigurations.ID == null)
				LoadNull ();
			WriteToFile (BasicDataConfigurations.ID, BasicDataConfigurations.age, BasicDataConfigurations.gender, BasicDataConfigurations.handedness, QuestionManager.questionnaireItem,  SceneManager.GetActiveScene().name, ApplyRandomDelays.conditionDelayTime.ToString(), 
                BasicDataConfigurations.condition, QuestionManager.VASvalue, TrialOnsetAndOffsetTime.onsetTime.ToString(), TrialOnsetAndOffsetTime.offsetTime.ToString());
		}

		void LoadNull(){
			string na = "na";
			BasicDataConfigurations.ID = na;
			BasicDataConfigurations.age = na;
			BasicDataConfigurations.gender = na;
			BasicDataConfigurations.handedness = na;
            BasicDataConfigurations.condition = na;
			ConditionDictionary.selectedOrder = new string[3] {na, na, na};
		}

        void WriteToFile(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k) {

            string stringLine = a + "," + b + "," + c + "," + d + "," + e + "," + f + "," + g + "," + h + "," + i + "," + j + "," + k;

			System.IO.StreamWriter file = new System.IO.StreamWriter("./Logs/" + BasicDataConfigurations.ID + "_log.csv", true);
			file.WriteLine(stringLine);
			file.Close();	
		}
	}
}