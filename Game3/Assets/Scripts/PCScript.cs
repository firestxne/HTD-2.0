using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCScript : MonoBehaviour {

    // Use this for initialization
    bool interact;
    [SerializeField] GameObject terminalUI;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (interact) { 
        Debug.Log("TESt");
        Debug.Log(collision.gameObject.tag);
        terminalUI.SetActive(true);
    }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        terminalUI.SetActive(false);
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            interact = true;
        }
        else
            interact = false;
	}
}
