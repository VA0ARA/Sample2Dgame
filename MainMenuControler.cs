using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuControler : MonoBehaviour
{
    public void playGame() {
        //just get name of Player convert that to intiger and then save it in SelectedChracter
        int SelectedChracter =
            int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        //first create instance and then  intialaze the characterIndex atrebute of
        //intance of GGameManager and pass GGameManager to other scence 
        GGameManager.Instance.charindex = SelectedChracter;
        SceneManager.LoadScene("SampleScene");
    }
     

    // Debug.Log(" bam");
   
}
 


