using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float speed;
    private Rigidbody2D mybody;

    
    void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        speed = 3;
        
    }

    
    void FixedUpdate()
    {
        mybody.velocity = new Vector2(speed, mybody.velocity.y);

        
    }
}
