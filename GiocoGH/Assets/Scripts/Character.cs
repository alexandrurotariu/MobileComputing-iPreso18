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
    private bool isdead = false;
    public ParticleSystem dust;

    [SerializeField]
    public GameObject gameOverUI;

    private float timer = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }



    void Update()
    {

        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        anim.SetBool("isgrounded", isTouchingGround);
        bool jetpackActive = Input.GetButton("Fire1");

        if (isTouchingGround)
            createDust();

        if (jetpackActive && isTouchingGround)
        {
            rb.AddForce(new Vector2(0, jumpForce));
            createDust();
        }

        if (isdead)
        {
            gameOverUI.SetActive(true);
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Time.timeScale = 0f;
            }
        }
       
    }

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Spike")
        {
            anim.SetBool("isdead", true);
            isdead = true;
        }
    }

    void createDust()
    {
        dust.Play();
    }
}


