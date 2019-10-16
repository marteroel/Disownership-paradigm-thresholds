using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using WebcamDelay;

namespace SimpleVAS
{

    public class LoadSceneOnTime : MonoBehaviour
    {

        public string sceneToLoad;
        public float waitingTime;

        // Use this for initialization
        void Start()
        {
            StartCoroutine("ChangeSceneAtTime");
        }

        // Update is called once per frame
        void Update()
        {

        }

        private IEnumerator ChangeSceneAtTime()
        {

            yield return new WaitForFixedTime(waitingTime);
            SceneManager.LoadScene(sceneToLoad);

        }

    }
}