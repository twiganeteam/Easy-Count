using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDrag : MonoBehaviour
{
    static public int numLives = 9;
    static public int score = 9;
   
    void start()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
       GameObject go = GameObject.Find("dragging");
        if (go == null)
        {
            Debug.LogError("Failed to find an object named Score");
            this.enabled = false;
            return;
            //GetComponent<Text>().text = "score: " + 0 + "Lives: " + 0;
        }
        else
        {
            GetComponent<Text>().text = " " + " " + Answers_Script.score + "      ";
        }
        //GameStatus gs = go.GetComponent<GameStatus>();
    }
}
