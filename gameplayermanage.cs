using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameplayermanage : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");

    }
    public void home()
    {
        SceneManager.LoadScene("Mainmenu");

    }

}
