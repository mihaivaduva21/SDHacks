using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public GameObject UI;
    void enableUI()
    {
        UI.SetActive(true);
    }

    void  disableUI()
    {
        UI.SetActive(false);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
