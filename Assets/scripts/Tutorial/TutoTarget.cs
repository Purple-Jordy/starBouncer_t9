using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoTarget : MonoBehaviour
{
    public GameObject Panel;
    public GameObject ReviveButton;
    public GameObject RetryButton;
    public GameObject star;
    public GameObject key;

    // Start is called before the first frame update
    void OnBecameInvisible()
    {
        star.GetComponent<CircleMove>().rigid.velocity = Vector2.zero;
        star.GetComponent<CircleMove>().circleMove = false;
        star.SetActive(false);

        if (Panel)
        {
            Panel.SetActive(true);

            if (key.GetComponent<TutoKeySystem>().count < 2)
            {
                ReviveButton.SetActive(false);
                RetryButton.SetActive(true);
            }


        }

        }
    }
