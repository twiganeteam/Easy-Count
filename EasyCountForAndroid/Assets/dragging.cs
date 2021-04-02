using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dragging : MonoBehaviour
{

    [SerializeField]
    private Transform bearplace;
    private Vector2 initialPosition;
    private Vector2 mousePosition;
    private float deltaX, deltaY;
    public static bool locked;

    public ParticleSystem particleSys9;

    public AudioSource audioSource;
    public AudioClip audioClip;


    public Sprite item1;
    public Sprite item2;
    public Sprite item3;
    public Sprite item4;
    public Sprite item5;
    public Sprite item6;
    public Sprite item7;
    public Sprite item8;
    public Sprite item9;
    public Sprite item10;

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


    public GameObject correct;
    public GameObject wrong;

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

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        score = 0;
        // particleSys = GameObject.Find("CorrectAnswer").GetComponent<ParticleSystem>();
        particleSys9.Stop();

    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1 && activity1.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos1 = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                        {
                            deltaX = touchPos1.x - transform.position.x;
                            deltaY = touchPos1.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))

                            transform.position = new Vector2(touchPos1.x - deltaX, touchPos1.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;

                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                            {
                                particleSys9.Play();
                                //correct.SetActive(true);
                                wrong.SetActive(false);

                                score = score + 3;
                                Level_001.SetActive(false);
                                Level_003.SetActive(true);
                                Keyboard1.SetActive(false);
                                Keyboard2.SetActive(true);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2 && activity1.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3 && activity1.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4 && activity1.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                //numLives = numLives - 1;
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }


        // ACTIVITY NUMBER TWO

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4 && activity2.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos1 = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                        {
                            deltaX = touchPos1.x - transform.position.x;
                            deltaY = touchPos1.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))

                            transform.position = new Vector2(touchPos1.x - deltaX, touchPos1.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;

                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                            {
                                particleSys9.Play();
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
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1 && activity2.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2 && activity2.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3 && activity2.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                //numLives = numLives - 1;
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        // ACTIVITY NUMBER THREE

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1 && activity3.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos1 = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                        {
                            deltaX = touchPos1.x - transform.position.x;
                            deltaY = touchPos1.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))

                            transform.position = new Vector2(touchPos1.x - deltaX, touchPos1.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;

                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                            {
                                particleSys9.Play();

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
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2 && activity3.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3 && activity3.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4 && activity3.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                //numLives = numLives - 1;
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        // ACTIVITY NUMBER FOUR

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4 && activity4.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos1 = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                        {
                            deltaX = touchPos1.x - transform.position.x;
                            deltaY = touchPos1.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))

                            transform.position = new Vector2(touchPos1.x - deltaX, touchPos1.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;

                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                            {
                                particleSys9.Play();

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
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2 && activity4.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3 && activity4.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1 && activity4.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                //numLives = numLives - 1;
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        // ACTIVITY NUMBER FIVE

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4 && activity5.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos1 = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                        {
                            deltaX = touchPos1.x - transform.position.x;
                            deltaY = touchPos1.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))

                            transform.position = new Vector2(touchPos1.x - deltaX, touchPos1.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;

                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                            {
                                particleSys9.Play();

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
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2 && activity5.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3 && activity5.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1 && activity5.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                //numLives = numLives - 1;
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        // ACTIVITY NUMBER SIX

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3 && activity6.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos1 = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                        {
                            deltaX = touchPos1.x - transform.position.x;
                            deltaY = touchPos1.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))

                            transform.position = new Vector2(touchPos1.x - deltaX, touchPos1.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;

                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                            {
                                particleSys9.Play();
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
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2 && activity6.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4 && activity6.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1 && activity6.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                //numLives = numLives - 1;
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        // ACTIVITY NUMBER SEVEN

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3 && activity7.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos1 = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                        {
                            deltaX = touchPos1.x - transform.position.x;
                            deltaY = touchPos1.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))

                            transform.position = new Vector2(touchPos1.x - deltaX, touchPos1.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;

                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                            {
                                particleSys9.Play();

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
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2 && activity7.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4 && activity7.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1 && activity7.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                //numLives = numLives - 1;
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        // ACTIVITY NUMBER EIGHT

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2 && activity8.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos1 = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                        {
                            deltaX = touchPos1.x - transform.position.x;
                            deltaY = touchPos1.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))

                            transform.position = new Vector2(touchPos1.x - deltaX, touchPos1.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;

                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                            {
                                particleSys9.Play();
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
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3 && activity8.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4 && activity8.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1 && activity8.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                //numLives = numLives - 1;
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        // ACTIVITY NUMBER NINE

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3 && activity9.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos1 = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                        {
                            deltaX = touchPos1.x - transform.position.x;
                            deltaY = touchPos1.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))

                            transform.position = new Vector2(touchPos1.x - deltaX, touchPos1.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;

                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                            {
                                particleSys9.Play();

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
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2 && activity9.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4 && activity9.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1 && activity9.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                //numLives = numLives - 1;
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        // ACTIVITY NUMBER TEN

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1 && activity10.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos1 = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                        {
                            deltaX = touchPos1.x - transform.position.x;
                            deltaY = touchPos1.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))

                            transform.position = new Vector2(touchPos1.x - deltaX, touchPos1.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item1)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;

                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1))
                            {
                                particleSys9.Play();

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
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2 && activity10.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item2)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3 && activity10.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item3)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4 && activity10.activeSelf == true)
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == item4)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                //numLives = numLives - 1;
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            GameObject.DontDestroyOnLoad(this.gameObject);
                        }
                        break;
                }
            }
        }
    }
}
