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

    // Update is called once per frame
    void Update()
    {
        PlyerMOveKeyboard();
        AnimatPlyer();


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
}
