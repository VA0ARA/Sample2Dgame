using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    private Vector3 tempos;
    [SerializeField]
    private float Minx, MaxX;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        
    }

    // it call after updat tiny good for follow thing or chasing behavior.....
    void LateUpdate()
    {
        //when we use retun in void method
        //after condition is ok function dont excute other line
       if( !player)
            return;       
        tempos = transform.position;
        tempos.x = player.position.x;
        if (tempos.x < Minx)
            tempos.x = Minx;
        if (tempos.x > MaxX)
            tempos.x = MaxX;
        transform.position = tempos;
        
    }
}
