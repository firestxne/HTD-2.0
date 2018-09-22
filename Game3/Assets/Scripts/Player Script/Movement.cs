using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    // Use this for initialization
    
    [SerializeField] GameObject floppy;
    bool interact = false;
    bool hacking = false;
    bool admin = false; //set true if floppy recieved
    bool playerMoving;
    Vector3 moving;
    Vector2 lastMove;
//    [SerializeField] float speed;
//	Animator ani ;
    //SpriteRenderer spritere;

	[SerializeField] float moveSpeed;
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

    public bool adminkey()
    {
        return admin;
    }

    public void Inventory()
    {
        if(!floppy.activeSelf)
        {
            admin = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Floppy")
        {
            Debug.Log(collision.gameObject.tag);
            collision.gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Security")
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void Start()
    {
        
		ani = GetComponent<Animator> ();

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
        Inventory();
    }

    void Update()
    {
        if (Input.GetAxisRaw("Interact")>0.1f)
        {
            interact = true;
        }
        else
            interact = false;
    }
}
