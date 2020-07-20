using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleVAS;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProprioceptiveTask : MonoBehaviour {

    private List<int> options = new List<int>() { 15, 10, 5, -5, -10, -15 };
    public Text conditionText;
    public InputField responseField;
    public string sceneToLoad;
    private string response;
    private int selectedItem;


    // Use this for initialization
    void Start () {

        ShuffleItem();
        WriteToFile("subject ID", "question", "response");

    }
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown("return")){
            WriteToFile(BasicDataConfigurations.ID, selectedItem.ToString(), responseField.text);
            ShuffleItem();
        }
	}
    
    private void ShuffleItem(){

        if (options.Count < 1 ) {
            SceneManager.LoadScene(sceneToLoad);
            //Debug.Log("finished");
        }
        else {

            int randomIndex = Random.Range(0, options.Count);
            selectedItem = options[randomIndex];

            options.RemoveAt(randomIndex);

            conditionText.text = selectedItem.ToString();

            responseField.text = "";
        }

    }

    void WriteToFile(string a, string b, string c)
    {

        string stringLine = a + "," + b + "," + c;

        System.IO.StreamWriter file = new System.IO.StreamWriter("./Logs/" + BasicDataConfigurations.ID + "_prop.csv", true);
        file.WriteLine(stringLine);
        file.Close();
    }


}
