using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndLevels : MonoBehaviour
{
    public Button levelButton1;
    public Button levelButton2;
    public Button levelButton3;
    public Button levelButton4;
    public Button levelButton5;
    // Start is called before the first frame update
    void Start()
    {
        levelButton2.interactable = true;
        levelButton3.interactable = true;
        levelButton4.interactable = true;
        levelButton5.interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnYegoClick()
    {
        SceneManager.LoadScene("Levels");
    }
}
