using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float MoveForce = 10f;
    [SerializeField]
    public float jumpForce = 11f;
    private float MovmentX;
    private Rigidbody2D mybody;
    private SpriteRenderer sr;
    private Animator anim;
    private string WAlkANImation = "Walk1";// condition we set in animation 
    private bool IsGrounded; // for limit the jump 
    private string Tagname = "Ground";
    private void Awake()
    {
        // just intialaze compotion 
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

    }

    void Start()
    {
        
        
    }

    // for getting  input 
    void Update()
    {
        PlyerMOveKeyboard();
        AnimatPlyer();
        





    }
    // good for physics caculation
    private void FixedUpdate()
    {
        Jump();
    }
    private void PlyerMOveKeyboard()
    {
        MovmentX = Input.GetAxisRaw("Horizontal");
        // Debug.Log(MovmentX);
        transform.position += new Vector3(MovmentX, 0f, 0f)*Time.deltaTime*MoveForce; 

    }
    private void AnimatPlyer()
    {
        if (MovmentX > 0) {
            anim.SetBool(WAlkANImation, true);
            sr.flipX = false;
        
        }
        else if(MovmentX<0) {
            anim.SetBool(WAlkANImation, true);
            sr.flipX = true;


        }
        else
        {
            anim.SetBool(WAlkANImation, false);

        }

    }
    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            IsGrounded = false;
           // Debug.Log("press");// return true press and releas
            mybody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            

        }
        
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(Tagname))
        {
            Debug.Log("ground");
            IsGrounded = true;
        }
    }

}
