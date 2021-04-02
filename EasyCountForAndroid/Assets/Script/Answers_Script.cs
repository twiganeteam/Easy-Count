using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answers_Script : MonoBehaviour
{

    public ParticleSystem particleSys;
    public ParticleSystem particleSys2;
    public ParticleSystem particleSys3;
    public ParticleSystem particleSys4;
    public ParticleSystem particleSys5;
    public ParticleSystem particleSys6;
    public ParticleSystem particleSys7;
    public ParticleSystem particleSys8;
    public ParticleSystem particleSys9;

    public AudioSource audioSource;
    public AudioClip audioClip;

    public GameObject activity1;
    public GameObject activity2;
    public GameObject activity3;
    public GameObject activity4;
    public GameObject activity5;
    public GameObject activity6;
    public GameObject activity7;
    public GameObject activity8;
    public GameObject activity9;
    public GameObject activity10;

    // Answers for easy count Level 1
    public GameObject Answer1;
    public GameObject Answer2;
    public GameObject Answer3;
    public GameObject Answer4;
    public GameObject Answer5;
    public GameObject Answer6;
    public GameObject Answer7;
    public GameObject Answer8;
    public GameObject Answer9;
    public GameObject Answer10;
    public GameObject Answer11;
    public GameObject Answer12;

    public GameObject correct;
    public GameObject wrong;

    // Exercises for easy count Level 1

    public GameObject Level_001;
    public GameObject Level_003;
    public GameObject Level_004;
    public GameObject Level_005;
    public GameObject Level_006;
    public GameObject Level_007;
    public GameObject Level_008;
    public GameObject Level_009;
    public GameObject Level_010;
    public GameObject Level_011;
    public GameObject EndOfLevel1;

   // public GameObject SliderBar;
    //public GameObject SliderBarStart;


    // Keyboard for easy count level 1

    public GameObject Keyboard1;
    public GameObject Keyboard2;
    public GameObject Keyboard3;
    public GameObject Keyboard4;
    public GameObject Keyboard5;
    public GameObject Keyboard6;
    public GameObject Keyboard7;
    public GameObject Keyboard8;
    public GameObject Keyboard9;
    public GameObject Keyboard10;
    public GameObject Keyboard11;

    static public int numLives = 9;
    static public int score = 9;
    public int count;
    public float sec = 14f;

    void Start()
    {
        numLives = 9;
        score = 0;
       // particleSys = GameObject.Find("CorrectAnswer").GetComponent<ParticleSystem>();
        particleSys.Stop();
        particleSys2.Stop();
        particleSys3.Stop();
        particleSys4.Stop();
        particleSys5.Stop();
        particleSys6.Stop();
        particleSys7.Stop();
        particleSys8.Stop();
        particleSys9.Stop();
        //sound.Stop();
}
    public void OnCorrectChoice()
    {
        if (activity1.activeSelf == true || this.gameObject.GetComponent<GameObject>() == Answer4)
        {
           
            particleSys.Play();
            audioSource.clip = audioClip;
            audioSource.Play();
            correct.SetActive(true);
            wrong.SetActive(false);
           // SliderBar.SetActive(true);
           // SliderBarStart.SetActive(false);

            score = score + 3;

            Level_001.SetActive(false);
            Level_003.SetActive(true);
            correct.SetActive(true);
            Keyboard1.SetActive(false);
            Keyboard2.SetActive(true);

        }
    }
    public void OnCorrectChoiceActivity2()
    {
        if (activity2.activeSelf == true || this.gameObject.GetComponent<GameObject>() == Answer1)
        {
            particleSys2.Play();
            correct.SetActive(true);
            wrong.SetActive(false);

            activity1.SetActive(false);
            activity2.SetActive(false);

            score = score + 3;

            Level_001.SetActive(false);
            Level_003.SetActive(false);
            Level_004.SetActive(true);
            Keyboard1.SetActive(false);
            Keyboard2.SetActive(false);
            Keyboard3.SetActive(true);
        }
    }
    public void OnCorrectChoiceActivity3()
    {
        if (activity3.activeSelf == true || this.gameObject.GetComponent<GameObject>() == Answer7)
        {
            particleSys3.Play();
            correct.SetActive(true);
            wrong.SetActive(false);

            activity1.SetActive(false);
            activity2.SetActive(false);
            activity3.SetActive(false);

            score = score + 3;

            Level_001.SetActive(false);
            Level_003.SetActive(false);
            Level_004.SetActive(false);
            Level_005.SetActive(true);
            Keyboard1.SetActive(false);
            Keyboard2.SetActive(false);
            Keyboard3.SetActive(false);
            Keyboard4.SetActive(true);
        }
    }
    public void OnCorrectChoiceActivity4()
    {
        if (activity4.activeSelf == true || this.gameObject.GetComponent<GameObject>() == Answer6)
        {
            particleSys4.Play();
            correct.SetActive(true);
            wrong.SetActive(false);
            
            activity1.SetActive(false);
            activity2.SetActive(false);
            activity3.SetActive(false);

            score = score + 3;

            Level_001.SetActive(false);
            Level_003.SetActive(false);
            Level_004.SetActive(false);
            Level_005.SetActive(false);
            Level_006.SetActive(true);
            Keyboard1.SetActive(false);
            Keyboard2.SetActive(false);
            Keyboard3.SetActive(false);
            Keyboard4.SetActive(false);
            Keyboard5.SetActive(true);
        }
    }
    public void OnCorrectChoiceActivity5()
    {
        if (activity5.activeSelf == true || this.gameObject.GetComponent<GameObject>() == Answer12)
        {
            particleSys5.Play();
            correct.SetActive(true);
            wrong.SetActive(false);
           
            activity1.SetActive(false);
            activity2.SetActive(false);
            activity3.SetActive(false);

            score = score + 3;

            //ACTIVITIES FOR LEVEL ONE
            Level_001.SetActive(false);
            Level_003.SetActive(false);
            Level_004.SetActive(false);
            Level_005.SetActive(false);
            Level_006.SetActive(false);
            Level_007.SetActive(true);

            //KEYBOARD FOR EASY COUNT 2D GAME
            Keyboard1.SetActive(false);
            Keyboard2.SetActive(false);
            Keyboard3.SetActive(false);
            Keyboard4.SetActive(false);
            Keyboard5.SetActive(false);
            Keyboard6.SetActive(true);
        }
    }
    public void OnCorrectChoiceActivity6()
    {
        if (activity6.activeSelf == true || this.gameObject.GetComponent<GameObject>() == Answer3)
        {
            particleSys6.Play();
            correct.SetActive(true);
            wrong.SetActive(false);
     
            activity1.SetActive(false);
            activity2.SetActive(false);
            activity3.SetActive(false);

            score = score + 3;

            //ACTIVITIES FOR LEVEL ONE
            Level_001.SetActive(false);
            Level_003.SetActive(false);
            Level_004.SetActive(false);
            Level_005.SetActive(false);
            Level_006.SetActive(false);
            Level_007.SetActive(false);
            Level_008.SetActive(true);

            //KEYBOARD FOR EASY COUNT 2D GAME
            Keyboard1.SetActive(false);
            Keyboard2.SetActive(false);
            Keyboard3.SetActive(false);
            Keyboard4.SetActive(false);
            Keyboard5.SetActive(false);
            Keyboard6.SetActive(false);
            Keyboard7.SetActive(true);
        }
    }
    public void OnCorrectChoiceActivity7()
    {
        if (activity7.activeSelf == true || this.gameObject.GetComponent<GameObject>() == Answer5)
        {
            particleSys7.Play();
            correct.SetActive(true);
            wrong.SetActive(false);
            
            activity1.SetActive(false);
            activity2.SetActive(false);
            activity3.SetActive(false);

            score = score + 3;

            //ACTIVITIES FOR LEVEL ONE
            Level_001.SetActive(false);
            Level_003.SetActive(false);
            Level_004.SetActive(false);
            Level_005.SetActive(false);
            Level_006.SetActive(false);
            Level_007.SetActive(false);
            Level_008.SetActive(false);
            Level_009.SetActive(true);

            //KEYBOARD FOR EASY COUNT 2D GAME
            Keyboard1.SetActive(false);
            Keyboard2.SetActive(false);
            Keyboard3.SetActive(false);
            Keyboard4.SetActive(false);
            Keyboard5.SetActive(false);
            Keyboard6.SetActive(false);
            Keyboard7.SetActive(false);
            Keyboard8.SetActive(true);
        }
    }
    public void OnCorrectChoiceActivity8()
    {
        if (activity8.activeSelf == true || this.gameObject.GetComponent<GameObject>() == Answer11)
        {
            particleSys8.Play();
            correct.SetActive(true);
            wrong.SetActive(false);
          
            activity1.SetActive(false);
            activity2.SetActive(false);
            activity3.SetActive(false);

            score = score + 3;

            //ACTIVITIES FOR LEVEL ONE
            Level_001.SetActive(false);
            Level_003.SetActive(false);
            Level_004.SetActive(false);
            Level_005.SetActive(false);
            Level_006.SetActive(false);
            Level_007.SetActive(false);
            Level_008.SetActive(false);
            Level_009.SetActive(false);
            Level_010.SetActive(true);

            //KEYBOARD FOR EASY COUNT 2D GAME
            Keyboard1.SetActive(false);
            Keyboard2.SetActive(false);
            Keyboard3.SetActive(false);
            Keyboard4.SetActive(false);
            Keyboard5.SetActive(false);
            Keyboard6.SetActive(false);
            Keyboard7.SetActive(false);
            Keyboard8.SetActive(false);
            Keyboard9.SetActive(true);
        }
    }
    public void OnCorrectChoiceActivity9()
    {
        if (activity9.activeSelf == true || this.gameObject.GetComponent<GameObject>() == Answer10)
        {
            particleSys9.Play();
            correct.SetActive(true);
            wrong.SetActive(false);
            
            activity1.SetActive(false);
            activity2.SetActive(false);
            activity3.SetActive(false);

            score = score + 3;

            //ACTIVITIES FOR LEVEL ONE
            Level_001.SetActive(false);
            Level_003.SetActive(false);
            Level_004.SetActive(false);
            Level_005.SetActive(false);
            Level_006.SetActive(false);
            Level_007.SetActive(false);
            Level_008.SetActive(false);
            Level_009.SetActive(false);
            Level_010.SetActive(false);
            Level_011.SetActive(true);

            //KEYBOARD FOR EASY COUNT 2D GAME
            Keyboard1.SetActive(false);
            Keyboard2.SetActive(false);
            Keyboard3.SetActive(false);
            Keyboard4.SetActive(false);
            Keyboard5.SetActive(false);
            Keyboard6.SetActive(false);
            Keyboard7.SetActive(false);
            Keyboard8.SetActive(false);
            Keyboard9.SetActive(false);
            Keyboard10.SetActive(true);
        }
    }
    public void OnCorrectChoiceActivity10()
    {
        if (activity10.activeSelf == true || this.gameObject.GetComponent<GameObject>() == Answer9)
        {
            particleSys5.Play();
            correct.SetActive(false);
            wrong.SetActive(false);
           
            activity1.SetActive(false);
            activity2.SetActive(false);
            activity3.SetActive(false);

            score = score + 3;

            //ACTIVITIES FOR LEVEL ONE
            Level_001.SetActive(false);
            Level_003.SetActive(false);
            Level_004.SetActive(false);
            Level_005.SetActive(false);
            Level_006.SetActive(false);
            Level_007.SetActive(false);
            Level_008.SetActive(false);
            Level_009.SetActive(false);
            Level_010.SetActive(false);
            Level_011.SetActive(false);
            EndOfLevel1.SetActive(true);

            //KEYBOARD FOR EASY COUNT 2D GAME
            Keyboard1.SetActive(false);
            Keyboard2.SetActive(false);
            Keyboard3.SetActive(false);
            Keyboard4.SetActive(false);
            Keyboard5.SetActive(false);
            Keyboard6.SetActive(false);
            Keyboard7.SetActive(false);
            Keyboard8.SetActive(false);
            Keyboard9.SetActive(false);
            Keyboard10.SetActive(false);
            Keyboard11.SetActive(false);

        }
    }
    public void OnWrongChoice()
    {

        wrong.SetActive(true);
        correct.SetActive(false);
    }
    public void OnWrongChoiceActivity2()
    {
        wrong.SetActive(true);
        correct.SetActive(false);
    }
    // ############################   ACTIVITY TWO ######################################################   
}
