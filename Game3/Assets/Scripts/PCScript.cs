using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCScript : MonoBehaviour {

    // Use this for initialization
    [SerializeField] GameObject terminalUI;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
            if (collision.gameObject.tag=="Player")
            {
                Debug.Log(collision.gameObject.tag);
                terminalUI.SetActive(true);
            }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(collision.gameObject.tag);
            terminalUI.SetActive(false);
        }
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
