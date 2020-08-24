using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneConditionally : MonoBehaviour {

    public string sceneToLoadOnFalse, sceneToLoadOnTrue;
    public Toggle _toggle;
    

        public void OnNextButton()
        {

            if (!_toggle.isOn)
                SceneManager.LoadScene(sceneToLoadOnFalse);
            else
            SceneManager.LoadScene(sceneToLoadOnTrue);
    }
    }
