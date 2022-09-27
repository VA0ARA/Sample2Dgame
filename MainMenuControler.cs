using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuControler : MonoBehaviour
{
    public void playGame() {
/*        int SelectedChracter = 
            int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        GGameManager.Instance.charindex = SelectedChracter;*/
        SceneManager.LoadScene("SampleScene");
    }
     

    // Debug.Log(" bam");
   
}
 


