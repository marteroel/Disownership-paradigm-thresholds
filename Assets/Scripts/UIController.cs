using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

    public bool show;
	// Use this for initialization
	void Awake () {
        ShowHideUICamera.instance.ShowOrHide(show);
	}

}
