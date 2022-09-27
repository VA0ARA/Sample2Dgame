using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reciver : MonoBehaviour
{
    //subscribe
    private void OnEnable()
    {
        Sender.palyerDieInfo += PlayerDeadListner;

    }
    //unsubscrib
     void OnDisable()
    {
        Sender.palyerDieInfo -= PlayerDeadListner;

    }
    //this signiture must forms like deligate signiture 
    void PlayerDeadListner()
    {
        print("Event has call this function  to excecude");
        
    }

}
