using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarTwo : MonoBehaviour
{
    private Slider slider;
    private ParticleSystem particleSys;
    public float FillSpeed = 0.05f;
    private float targetProgress = 0.10f;
    public GameObject slidebar4;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        particleSys = GameObject.Find("Progress Bar Particals").GetComponent<ParticleSystem>();
    }
    // Start is called before the first frame update
    void Start()
    {
        IncrementProgress(0.10f);

    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
        {
            slider.value += FillSpeed * Time.deltaTime;
            if (!particleSys.isPlaying)
                particleSys.Play();
        }
        else
        {
            particleSys.Stop();
        }
    }
    // ADD PROGRESS TO THE BAR

    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }
}
