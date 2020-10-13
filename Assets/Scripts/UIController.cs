using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

    public bool show;

	void Start () {
        ShowHideUICamera.instance.ShowOrHide(show);
	}

}
