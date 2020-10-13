using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMDcontrols : MonoBehaviour {

    public bool showUI, log;

	void Start () {
        ShowHideUICamera.instance.ShowOrHide(showUI);
        HandTracking.instance.LogOnOff(log);
	}

}
