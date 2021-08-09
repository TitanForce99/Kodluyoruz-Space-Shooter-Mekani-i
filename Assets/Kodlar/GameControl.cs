using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameControl : MonoBehaviour
{
    public GameObject hazard;
    public Vector3 rand;
    public int hazardCount;

    private GameControl control;
    public Text text;
    int score;
    void Start()
    {
        score = 0;
        text.text = "score =" + score;
        StartCoroutine(Spawn());
    }


    IEnumerator Spawn()
    {

        while (true)
        {
            yield return new WaitForSeconds(2);
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-rand.x, rand.x), rand.y, rand.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(0.7f);
            }
            yield return new WaitForSeconds(2);
        }
    }
    public void Scoreİncrease(int gelenscore)
    {
        score += gelenscore;
        text.text = "score =" + score;
         Debug.Log(score);
    }
}
