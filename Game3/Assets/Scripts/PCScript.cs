using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCScript : MonoBehaviour {

    // Use this for initialization
    [SerializeField] Movement player;
    bool interact;
    [SerializeField] bool admin=true;
    [SerializeField] GameObject terminalUI;

    void Start()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        interact = player.interaction();
        if (!admin)
        {
            admin = player.adminkey();
        }
        if (interact)
        {
            if (admin)
            {
                Debug.Log("TESt");
                Debug.Log(collision.gameObject.tag);
                terminalUI.SetActive(true);
                player.HackOn();
            }
            else
                Debug.Log("No Admin Privellege");
        }
        
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        terminalUI.SetActive(false);
    }

	
	// Update is called once per frame
	void Update () {
        
	}
}
