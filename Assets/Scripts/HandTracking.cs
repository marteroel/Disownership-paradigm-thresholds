﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleVAS;

public class HandTracking : MonoBehaviour {

    public Transform hand;

    private Vector3 _previousPosition;
    private bool logOn;

    public static HandTracking instance;
	public float _accel;

	public int number;

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    private void Start()
    {
        WriteToFile("ID", "delay", "condition", "pos_x", "pos_y", "pos_z", "rot_x", "rot_y", "rot_z", "acceleration", "sample_time");
    }

    public void LogOnOff(bool _log){
        logOn = _log;
    }

    private void Update()
    {
        if(logOn){
            _accel = Vector3.Distance(hand.position, _previousPosition) / Time.deltaTime;
            _previousPosition = hand.position;
			WriteToFile(BasicDataConfigurations.ID, ApplyRandomDelays.conditionDelayTime.ToString(), number.ToString(), 
                hand.position.x.ToString(), hand.position.y.ToString(), hand.position.z.ToString(),
                hand.rotation.eulerAngles.x.ToString(), hand.rotation.eulerAngles.y.ToString(), hand.rotation.eulerAngles.z.ToString(), 
				_accel.ToString(), Time.deltaTime.ToString(), BasicDataConfigurations.condition);
        }
    }


	private void WriteToFile(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l)
    {
		string stringLine = a + "," + b + "," + c + "," + d + "," + e + "," + f + "," + g + "," + h + "," + k + "," + i + "," + j + "," + k + "," + l;

        System.IO.StreamWriter file = new System.IO.StreamWriter("./Logs/" + BasicDataConfigurations.ID + "_handMovement_log.csv", true);
        file.WriteLine(stringLine);
        file.Close();
    }
}
