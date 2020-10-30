using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetChild : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 target = GameObject.FindWithTag ("VRUI").transform.eulerAngles;
		this.gameObject.transform.eulerAngles = target;
	}
}
