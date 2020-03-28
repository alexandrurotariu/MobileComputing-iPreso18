using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    public Animator anim;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    /*void Update()
    {
        if (Input.touchCount >0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            transform.localEulerAngles = new Vector3(0, 0, 20);
            rb.AddForce(new Vector2(0f, jumpForce),ForceMode2D.Force);
        }
        else
            transform.localEulerAngles = new Vector3(0, 0, 0);
        
    }
   
    void FixedUpdate()
    {
        bool jetpackActive = Input.GetButton("Fire1");
        if (jetpackActive)
        {
            rb.AddForce(new Vector2(0, jumpForce));
        }
    }
    */

    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        anim.SetBool("isgrounded", isTouchingGround);
        bool jetpackActive = Input.GetButton("Fire1");
     
            if (jetpackActive && isTouchingGround)
            {
                rb.AddForce(new Vector2(0, jumpForce));
  
            }
        }
    }
/*//make sure u replace "floor" with your gameobject name.on which player is standing
    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Floor")
        {
            isgrounded = true;
            anim.SetBool("isgrounded", true);
            Debug.Log("a terra");
        }
    }

    //consider when character is jumping .. it will exit collision.
    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Floor")
        {
            isgrounded = false;
            anim.SetBool("isgrounded", false);
            Debug.Log("vola");
        }
    }*/

