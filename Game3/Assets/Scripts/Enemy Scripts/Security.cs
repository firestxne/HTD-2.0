using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Security : MonoBehaviour {

    // Use this for initialization
    Vector3 playerPos;
    [SerializeField] float chaseDistance;
	void Start () {
        
	}

    void Chase()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, Time.deltaTime);
    }
	
	// Update is called once per frame
	void Update () {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        if(Vector3.Distance(transform.position, playerPos)<=chaseDistance)
        { 
        Chase();
        }
    }
}
