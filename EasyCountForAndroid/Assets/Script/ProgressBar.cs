using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public GameObject MyScene1;
    public GameObject MyScene2;
    public GameObject MyScene3;
    public GameObject MyScene4;
    public GameObject MyScene5;
    public GameObject MyScene6;
    public GameObject MyScene7;
    public GameObject MyScene8;
    public GameObject MyScene9;
    public GameObject MyScene10;
    public GameObject MyScene11;

    private Slider slider;
    public float FillSpeed = 0.5f;
    private float targetProgress = 0;
    private float num2 = 0.2f;
    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    // Start is called before the first frame update
    void Start()
    {
      IncrementProgress(0.10f);   
    }
    // Update is called once per frame
    void Update()
    {
       
        if (slider.value < targetProgress && MyScene1.activeSelf == true)
        {
            slider.value += FillSpeed * Time.deltaTime * 0;
        }
           
        if (slider.value < 0.1 && MyScene2.activeSelf == true)
        {
            slider.value += FillSpeed * Time.deltaTime;
           
        }
        if (slider.value < 0.2 && MyScene3.activeSelf == true)
        {
            slider.value += FillSpeed * Time.deltaTime;
        }
        if (slider.value < 0.3 && MyScene4.activeSelf == true)
        {
            slider.value += FillSpeed * Time.deltaTime;
        }
        if (slider.value < 0.4 && MyScene5.activeSelf == true)
        {
            slider.value += FillSpeed * Time.deltaTime;
        }
        if (slider.value < 0.5 && MyScene6.activeSelf == true)
        {
            slider.value += FillSpeed * Time.deltaTime;
        }
        if (slider.value < 0.6 && MyScene7.activeSelf == true)
        {
           slider.value += FillSpeed * Time.deltaTime;
        }
        if (slider.value < 0.7 && MyScene8.activeSelf == true)
        {
            slider.value += FillSpeed * Time.deltaTime;
        }
        if (slider.value < 0.8 && MyScene9.activeSelf == true)
        {
            slider.value += FillSpeed * Time.deltaTime;
        }
        if (slider.value < 0.9 && MyScene10.activeSelf == true)
        {
            slider.value += FillSpeed * Time.deltaTime;
        }
        if (slider.value < 1 && MyScene11.activeSelf == true)
        {
            slider.value += FillSpeed * Time.deltaTime;
        }
    }

    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }
}
