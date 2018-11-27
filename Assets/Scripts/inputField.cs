using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputField : MonoBehaviour {

    public Button button;
    public InputField field1;
    public Dropdown dropdown;
    private bool originEntered, destEntered = false;

    void Start()
    {

        var se1 = new InputField.SubmitEvent();
        se1.AddListener(SubmitOrigin);


        dropdown.onValueChanged.AddListener(delegate { SubmitDest(dropdown); });
    

        field1.onEndEdit = se1;

        //or simply use the line below, 
        //input.onEndEdit.AddListener(SubmitName);  // This also works
    }

    private void SubmitOrigin(string arg0)
    {
        if (arg0.Length != 0 )
        {

            originEntered = true;
        }
        else{
            originEntered = false;
        }
    }

    private void SubmitDest(Dropdown change)
    {
        if (change.value > 0)
        {
            destEntered = true;
        }
        else{
            destEntered = false;
        }
    }

	private void Update()
	{
		
        if( destEntered && originEntered){

            button.gameObject.SetActive(true);
        }
        else{

            button.gameObject.SetActive(false);
        }
	}

}
