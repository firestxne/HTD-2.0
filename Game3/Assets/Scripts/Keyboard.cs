using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour {

	//Text InputText;
	Text Term;
	//string inpu="";
	private InputField input;

	void Awake() {
		input = GameObject.Find ("InputField").GetComponent<InputField> ();
        Term = GetComponentInParent<Text>();
    }

	//void Start()
	//{
	//    InputText = GetComponentInChildren<Text> ();
	    

	//}




	public void GetInput(string test)
	{
		Debug.Log ("You entered: " + test);
		//Debug.Log (Term.text);
		input.text = "";
        Term.text += test;
		if (test == "ass")
			Debug.Log ("You did some ass");
		//Debug.Log (InputText.text);
		//Term.text = inpu;
	}
}