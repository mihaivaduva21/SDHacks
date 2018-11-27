using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Align : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public GameObject UIController;
	// Update is called once per frame
	void Update () {
        Transform oldTransform;
        bool isSet = false;
        oldTransform = this.transform;
        int i = 0;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && Input.GetTouch(0).position.x < (Screen.width / 2) && isSet == false)
        {
            this.transform.Rotate(oldTransform.rotation.x, oldTransform.rotation.y - 1, oldTransform.rotation.z);
        }
        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && Input.GetTouch(0).position.x >= (Screen.width / 2) && isSet == false)
        {
            this.transform.Rotate(0, oldTransform.rotation.y + 1, 0);
        }

        
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && Input.GetTouch(0).position.y > (Screen.height - 600))
        {
            i++;
            if (i == 3)
            {
                isSet = true;
                UIController.SetActive(false);
            }
        }
    }
}
