using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour {

	//Text InputText;
	[SerializeField]Text Term;
    //string inpu="";
    GameObject terminalType;
	private InputField input;

	void Awake() {
		input = GameObject.Find ("InputField").GetComponent<InputField> ();
        //Term = GetComponentInParent<Text>();
        
    }

    //void Start()
    //{
    //    InputText = GetComponentInChildren<Text> ();


    //}




    public void GetInput(string test)
    {
        Debug.Log("You entered: " + test);
        //Debug.Log (Term.text);
        input.text = "";


        Term.text = "Operating System [Version 24.0.0.4]\n(c) 20XX Company Inc. \n" + shellCmds(test) + "\n";

        //Debug.Log (InputText.text);
        //Term.text = inpu;
    }

    public string shellCmds(string test)
    {
        if (test == "ls")
        {
            return test + "\n\t";
        }
        else if (test == "ls -la" || test == "ls -al" || test == "ls -a -l" || test == "ls -l -a")
        {
            return test + "\n\t wr--r--r     .hidden";
        }
        else
        {
            return test + ": Command is not supported or syntax is wrong";
        }

    }
}