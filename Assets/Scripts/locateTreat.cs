using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locateTreat : MonoBehaviour {

    private int currentWaypoint = 0;
    public GameObject[] targets;
    private Transform oldTransform;
    private GameObject target, infoFromUI;
    private string source, alphabet;
    public GameObject s1, s2, s3, s4;
	// Use this for initialization
	void Start () {
        
        infoFromUI = GameObject.Find("GameState");
        source = infoFromUI.GetComponent<InfoTransfer>().source;
        Debug.Log("Source form vuforia: " + source);

        alphabet = source.Substring(1);
        Debug.Log("Alphabet form vuforia: " + alphabet);

        int x = 0;

        Int32.TryParse(alphabet, out x);

        if (alphabet == "1" || x == 1)
        {
            targets[0] = s1;
        }
        else if (alphabet == "6" || alphabet == "5" || x == 5 || x == 6)
        {
            targets[0] = s2;
        }
        else if (alphabet == "10" || alphabet == "11" || x == 10 || x == 11)
        {
            targets[0] = s3;
        }
        else if (alphabet == "15" || x == 15)
        {
            targets[0] = s4;
        }
        target = targets[currentWaypoint];
    }

    
	// Update is called once per frame
	void Update () {
        if (target.activeSelf == false)
        {
            currentWaypoint++;
            if (currentWaypoint >= targets.Length) this.gameObject.SetActive(false);
            target = targets[currentWaypoint];
        }
        this.transform.LookAt(target.transform);
        oldTransform = this.transform;
        this.transform.Rotate(-90, 0, oldTransform.rotation.z);
	}

 }
