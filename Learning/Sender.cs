using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender : MonoBehaviour
{
    //jusk like newspapaerfactore
    public delegate void PlayerDie();
    //this is a newpaper
    public static event PlayerDie palyerDieInfo;
     void Start()
    {
        Invoke("ExcudeEvent", 5f);

    void ExcudeEvent()
    {
            if (palyerDieInfo != null)
            {
                palyerDieInfo();
            }
        }

    }

}
