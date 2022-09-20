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
    private string WAlkANImation = "walk";
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


    }
    private void PlyerMOveKeyboard()
    {
        MovmentX = Input.GetAxisRaw("Horizontal");
        // Debug.Log(MovmentX);
        transform.position += new Vector3(MovmentX, 0f, 0f)*Time.deltaTime*MoveForce; 

    }
}
