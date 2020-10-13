using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowHideUICamera : MonoBehaviour {


    public GameObject uireticle;
    public static ShowHideUICamera instance;


    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    // Use this for initialization
    public void ShowOrHide(bool show){
        if (show){
            uireticle.SetActive(true);
        }
        else
        {
            uireticle.SetActive(false);
        }
    }
}
