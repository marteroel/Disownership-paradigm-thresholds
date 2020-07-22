using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using SimpleVAS;

public class WaitToLoadScene : MonoBehaviour
{

    public string sceneToLoad;
    public float secondsToWait;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown("space"))
            StartCoroutine(LoadAfterPeriod(secondsToWait));
    }


    private IEnumerator LoadAfterPeriod(float time){

        yield return new WaitForSecondsRealtime(time);

        if (sceneToLoad != "")
            SceneManager.LoadScene(sceneToLoad);
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

