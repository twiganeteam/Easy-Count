using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dragging : MonoBehaviour
{

    [SerializeField]
    private Transform bearplace;
    private Vector2 initialPosition;
    private Vector2 mousePosition;
    private float deltaX, deltaY;
    public static bool locked;
    public static bool locked2;

    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;
    public GameObject item6;
    public GameObject item7;
    public GameObject item8;
    public GameObject item9;
    public GameObject item10;
    public GameObject item11;
    public GameObject item12;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level_4" && GetComponent<Image>().name == "item1")
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch2 = Input.GetTouch(0);
                Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                switch (touch2.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                        {
                            deltaX = touchPos2.x - transform.position.x;
                            deltaY = touchPos2.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (GetComponent<Image>().name == "item1")
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = true;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }
    }
}
