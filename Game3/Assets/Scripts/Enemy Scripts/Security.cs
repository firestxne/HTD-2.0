using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
        }
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
