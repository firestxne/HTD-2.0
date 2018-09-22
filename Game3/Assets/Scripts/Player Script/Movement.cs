using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    // Use this for initialization
    public bool interact = false;
    bool hacking = false;
    bool playerMoving;
    Vector3 moving;
    Vector2 lastMove;
//    [SerializeField] float speed;
//	Animator ani ;
    //SpriteRenderer spritere;

	public float moveSpeed;
	private Animator ani;
    
    public void HackOn()
    {
        hacking = true;
    }

    public void HackOff()
    {
        hacking = false;
    }

    public bool interaction()
    {
        return interact;
    }
    //[SerializeField] GameObject terminalUI1;
    //[SerializeField] GameObject terminalUI2;
/*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "PC1")
        {
            Debug.Log(collision.gameObject.tag);
            terminalUI1.SetActive(true);
        }
        if (collision.gameObject.tag == "PC2")
        {
            Debug.Log(collision.gameObject.tag);
            terminalUI2.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "PC1")
        {
            Debug.Log(collision.gameObject.tag);
            terminalUI1.SetActive(false);
        }
        if (collision.gameObject.tag == "PC2")
        {
            Debug.Log(collision.gameObject.tag);
            terminalUI2.SetActive(false);
        }
    }
    */
    void Start()
    {
        
		ani = GetComponent<Animator> ();
        //spritere = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!hacking)
        {
            playerMoving = false;

            if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
            {
                //transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
                playerMoving = true;
                lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
            }

            if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
            {
                playerMoving = true;
                lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
                //Debug.Log(lastMove.y);
                //transform.Translate (new Vector3 (Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime, 0f));

            }


            float hori = Input.GetAxis("Horizontal") * moveSpeed;
            float vert = Input.GetAxis("Vertical") * moveSpeed;
            moving = new Vector3(transform.position.x + hori, transform.position.y + vert, 0);
            transform.position = Vector3.Lerp(transform.position, moving, Time.deltaTime);

            //Debug.Log(Input.GetAxisRaw("Horizontal"));
            //Debug.Log(Input.GetAxisRaw("Vertical"));
            ani.SetFloat("Move X", Input.GetAxisRaw("Horizontal"));
            ani.SetFloat("Move Y", Input.GetAxisRaw("Vertical"));
            ani.SetBool("PlayerMove", playerMoving);
            ani.SetFloat("LastMoveX", lastMove.x);
            ani.SetFloat("LastMoveY", lastMove.y);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            interact = true;
        }
        else
            interact = false;
    }
}
