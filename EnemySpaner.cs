using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpaner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monterRefrence;
    [SerializeField]
    private Transform LeftPos, RightPos;
    private GameObject spanerMonster;
    private int RandomIndex;
    private int randosite;
    void Start()
    {
        StartCoroutine(SpawnMonster());
    }
    IEnumerator SpawnMonster()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            RandomIndex = Random.Range(0, monterRefrence.Length);
            randosite = Random.Range(0, 2);
            spanerMonster = Instantiate(monterRefrence[RandomIndex]);
            //build enemy from left side
            if (randosite == 0)
            {
                spanerMonster.transform.position = LeftPos.position;
                spanerMonster.GetComponent<Monster>().speed = Random.RandomRange(4, 10);
            }
            //build enemy from right side
            else
            {
                spanerMonster.transform.position = RightPos.position;
                spanerMonster.GetComponent<Monster>().speed = -Random.RandomRange(4, 10);
                spanerMonster.transform.localScale = new Vector3(-1f, 1f, 1f);


            }
        }//while


    }

}
