using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Handler : MonoBehaviour
{
    public Button levelButton1;
    public Button levelButton2;
    public Button levelButton3;
    public Button levelButton4;
    public Button levelButton5;
    public GameObject EndLevel;

  void Start()
    {
        if(SceneManager.GetActiveScene().name == "Levels")
        {
            levelButton2.interactable = false;
            levelButton3.interactable = false;
            levelButton4.interactable = false;
            levelButton5.interactable = false;
        }
        else if(SceneManager.GetActiveScene().name == "EndLevel1")
        {
            levelButton2.interactable = true;
            levelButton3.interactable = false;
            levelButton4.interactable = false;
            levelButton5.interactable = false;
        }
        else if (SceneManager.GetActiveScene().name == "End_Level_2")
        {
            levelButton2.interactable = true;
            levelButton3.interactable = true;
            levelButton4.interactable = false;
            levelButton5.interactable = false;
        }
        else if (SceneManager.GetActiveScene().name == "End_level_3")
        {
            levelButton2.interactable = true;
            levelButton3.interactable = true;
            levelButton4.interactable = true;
            levelButton5.interactable = false;
        }
    }
    public void OnQuitApplication()
    {
       Application.Quit();
    }
    public void OnClickPlay()
    {
        SceneManager.LoadScene("Levels");
    }
    public void OnLevelOneClick()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void OnScene1Load()
    {
        SceneManager.LoadScene("Levels");
    }
    public void OnClickStart()
    {
        SceneManager.LoadScene("Start_Scene");
    }
    public void OnbuttonDesabled()
    {
        //levelButton2.interactable = false;
       // levelButton3.interactable = false;
       // levelButton4.interactable = false;
       //levelButton5.interactable = false;
    }
    public void OnYegoClick()
    {
        SceneManager.LoadScene("EndLevel1");
    }


    // LEVEL TWO EASY COUNT BUTTONS HUNDLE

    public void OnlevelTwoLoad()
    {
        SceneManager.LoadScene("Level_2");
    }
    public void OnYegoLevel2Click()
    {
        SceneManager.LoadScene("End_Level_2");
    }

    public void OnLevelThreeLoad()
    {
        SceneManager.LoadScene("Level_3");
    }
    public void OnYegoLevel3Click()
    {
        SceneManager.LoadScene("End_level_3");
    }
    public void OnLevelFourLoad()
    {
        SceneManager.LoadScene("Level_4");
    }
}
