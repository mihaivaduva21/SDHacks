using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoTransfer : MonoBehaviour {

    private static bool created = false;

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
    }

    public InputField mainInputField;
    public Dropdown mainDropDown;
    public string source;
    public int dest;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void loadLevel()
    {
        Debug.Log("Loading level");
        source = mainInputField.text;
        dest = mainDropDown.value;

        SceneManager.LoadScene("Restroom", LoadSceneMode.Single);
        Debug.Log("Source: " + source + " Dest: " + dest);
    }

    public string getSource()
    {
        return source;
    }
}
