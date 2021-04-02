using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 40f;
    public GameObject GameOver;

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0") + " Sec";
        if(currentTime <= 0)
        {
            currentTime = 0;
            if(currentTime == 0)
            {
                GameOver.SetActive(true);
            }
        }

    }
}
