﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleVisibilty : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            this.showArrow();
        }
	}

    public GameObject Arrrow;
    void showArrow()
    {
        Arrrow.SetActive(true);
    }
}
