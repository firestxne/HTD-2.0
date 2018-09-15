using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerminalScript : MonoBehaviour {
	Text term;
	// Use this for initialization
	void Start () {
		term = GetComponent<Text> ();
		term.text = "hello";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
