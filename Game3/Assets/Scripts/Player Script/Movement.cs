using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    // Use this for initialization

    Vector3 moving;
//    [SerializeField] float speed;
//	Animator ani ;
    //SpriteRenderer spritere;

	public float moveSpeed;
	private Animator ani;


    void Start()
    {

		ani = GetComponent<Animator> ();
        //spritere = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

//		if (Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw ("Horizontal") < -0.5f) 
//		{
//			transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
//
//		}
//
//		if (Input.GetAxisRaw ("Vertical") > 0.5f || Input.GetAxisRaw ("Vertical") < -0.5f) 
//		{
//			transform.Translate (new Vector3 (Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime, 0f));
//
//		}


        float hori = Input.GetAxis("Horizontal")*moveSpeed;
        float vert = Input.GetAxis("Vertical")*moveSpeed;
        moving = new Vector3(transform.position.x + hori, transform.position.y + vert, 0);
        transform.position = Vector3.Lerp(transform.position, moving, Time.deltaTime);

		Debug.Log(Input.GetAxisRaw("Horizontal"));
		Debug.Log(Input.GetAxisRaw("Vertical"));
		ani.SetFloat ("Move X",Input.GetAxisRaw ("Horizontal"));
		ani.SetFloat ("Move Y",Input.GetAxisRaw ("Vertical"));
    }
}
