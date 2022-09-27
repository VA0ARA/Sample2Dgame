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

        // cosept of single toon is here means we destroy excess of them from our other scenes
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
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnlevelFinishedLoading;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnlevelFinishedLoading;
    }
    void OnlevelFinishedLoading(Scene scene,LoadSceneMode mode)
    {
        if(scene.name== "SampleScene")
        {
            Instantiate(Character[charindex]);
        }

    }

}
