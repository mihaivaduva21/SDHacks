using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePosition : MonoBehaviour {

    // Use this for initialization
    public GameObject infoFromUI;
    private string source;
    string alphabet;
    public GameObject cam, ground;

    public GameObject lan1, lan2, lan3, lan4;
    public GameObject f1, f2, f3;

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
            transform.position = new Vector3(41.01f, transform.position.y, transform.position.z);
            lan1.SetActive(true);  
        }
        else if (alphabet == "6" || alphabet == "5" || x == 5 || x == 6)
        {
            transform.position = new Vector3(26.38f, transform.position.y, transform.position.z);
            lan2.SetActive(true);
            f1.SetActive(true);
        }
        else if (alphabet == "10" || alphabet == "11" || x == 10 || x == 11)
        {
            transform.position = new Vector3(12.91f, transform.position.y, transform.position.z);
            lan3.SetActive(true);
            f1.SetActive(true);
            f2.SetActive(true);
        }
        else if (alphabet == "15" || x == 15)
        {
            transform.position = new Vector3(0f, transform.position.y, transform.position.z);
            lan4.SetActive(true);
            f1.SetActive(true);
            f2.SetActive(true);
            f3.SetActive(true);
        }

        string alphabet2 = source.Substring(0, 1);

        if (alphabet2.Equals("O") || alphabet2.Equals("o"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -1.85f);
        } else if (alphabet2.Equals("N") || alphabet2.Equals("n"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 1.073f);
        }
        else if (alphabet2.Equals("M") || alphabet2.Equals("m"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 3.729f);
        }
        else if (alphabet2.Equals("L") || alphabet2.Equals("l"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 7.38f);
        }
        else if (alphabet2.Equals("K") || alphabet2.Equals("k"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 10.76f);
        }
        else if (alphabet2.Equals("J") || alphabet2.Equals("j"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 14.02f);
        }
        else if (alphabet2.Equals("I") || alphabet2.Equals("i"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 16.98f);
        }
        else if (alphabet2.Equals("H") || alphabet2.Equals("h"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 20.082f);
        }
        else if (alphabet2.Equals("G") || alphabet2.Equals("g"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 23.4f);
        }
        else if (alphabet2.Equals("F") || alphabet2.Equals("f"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 26.597f);
        }
        else if (alphabet2.Equals("E") || alphabet2.Equals("e"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 29.88f);
        }
        else if (alphabet2.Equals("D") || alphabet2.Equals("d"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 32.89f);
        }
        else if (alphabet2.Equals("C") || alphabet2.Equals("c"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 36.1f);
        }
        else if (alphabet2.Equals("B") || alphabet2.Equals("b"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 39.33f);
        }
        else if (alphabet2.Equals("A") || alphabet2.Equals("a"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 42.51f);
        }
        
        transform.DetachChildren();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
