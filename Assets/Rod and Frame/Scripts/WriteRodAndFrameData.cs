﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleVAS;
namespace RodAndFrame {
    public class WriteRodAndFrameData : MonoBehaviour {

        private static WriteRodAndFrameData instance = null;
        public string participantID;

        public static WriteRodAndFrameData Instance {
            get { return instance; }
        }

        //This allows the start function to be called only once.
        private void Awake()
        {
            if (instance != null && instance != this)
            {
                Destroy(this.gameObject);
                return;
            }
            else
                instance = this;

            //DontDestroyOnLoad(this.gameObject);
        }

        // Use this for initialization
        void Start() {
            WriteToFile("subject ID", "trial", "repetition", "head x", "head y", "head z", "rod origin", "frame origin", "selection");
            participantID = BasicDataConfigurations.ID;
        }


        public void WriteToFile(string a, string b, string c, string d, string e, string f, string g, string h, string i) {

            string stringLine = a + "," + b + "," + c + "," + d + "," + e + "," + f + "," + g + "," + h + "," + i;

        System.IO.StreamWriter file = new System.IO.StreamWriter("./Logs/" + participantID + "_rf.csv", true);
        file.WriteLine(stringLine);
        file.Close();
    }
}
}
