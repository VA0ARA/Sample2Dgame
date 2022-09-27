using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GGameManager : MonoBehaviour
{
    public static GGameManager Instance;
    [SerializeField]
    private GameObject[] Character;
    private int _charindex;
    public  int charindex
    {
        get { return _charindex; }
        set { _charindex = value; }
    }
    private void Awake()
    {

        // consept of singltuon pattern is here means create just one pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
           
        else
        {
            Destroy(gameObject);
            //destroy doublecated
        }
    }

    // passing a index that we select them in mainmenu then in the gamesample scence player
    // that we selected resnatet to index we choose in menuScence
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnlevelFinishedLoading;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnlevelFinishedLoading;
    }
    void OnlevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "SampleScene")
        {
            Instantiate(Character[charindex]);
        }

    }

}
