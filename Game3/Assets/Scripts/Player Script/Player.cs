using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnCollision2D(Collision collision)
    {
        Debug.Log("you're getting hit");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
