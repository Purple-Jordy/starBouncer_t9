using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleTarget : MonoBehaviour
{
    
    public GameObject Panel;
    public GameObject ReviveButton;
    public GameObject RetryButton;
    public GameObject star;
    public GameObject key;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible()
    {
        star.GetComponent<CircleMove>().rigid.velocity = Vector2.zero;
        star.GetComponent<CircleMove>().circleMove = false;
        star.SetActive(false);

        if (Panel)
        {
            Panel.SetActive(true);


            if (key.GetComponent<keySystem>().count < 2)
            {
                ReviveButton.SetActive(false);
                RetryButton.SetActive(true);
            }


        }

        
            

    }



}
