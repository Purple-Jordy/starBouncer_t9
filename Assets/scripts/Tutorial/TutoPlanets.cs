using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class TutoPlanets : MonoBehaviour
{

    public float rotateSpeed;
    public GameObject star;
    public GameObject key;
    
    public Animator anim;
    public GameObject camTartget;
    bool touchStar = false;
    bool meet;
    public float center;

    //private bool clockWise = true;
    public float camSpeed;
    public float zoomSpeed;
    
    AudioSource audioSoure;



    // Start is called before the first frame update
    void Start()
    {
        audioSoure = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (meet == true)
        {


            camera campoint = GameObject.Find("Main Camera").GetComponent<camera>();
            campoint.target = camTartget; //카메라 타겟
            campoint.camwidth = center; // 카메라 커지는 넓이
            campoint.speed = camSpeed; // 카메라 타겟 속도
            campoint.zoomSpeed = zoomSpeed; // 카메라 확대 속도 
           
            
        }

    }

   

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("star"))
        {


            meet = true;
            anim.SetBool("touched", true);
            

            //<수정
            star.GetComponent<CircleMove>().rigid.velocity = Vector2.zero;
            star.GetComponent<CircleMove>().circleMove = false;

            star.GetComponent<CircleMove>().rotateSpeed = rotateSpeed;



            Vector3 v3 = this.transform.position - star.transform.position;


#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif



            if (touchStar == false)
            {
                audioSoure.Play();
                key.GetComponent<TutoKeySystem>().count += 1;
                touchStar = true;
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        meet = false;
    }

    private void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("star"))
        {
            if (star.GetComponent<CircleMove>().circleMove != true)
            {
                GameObject point = transform.GetChild(0).gameObject;
                star.transform.position = Vector2.MoveTowards(star.transform.position, point.transform.position, rotateSpeed * Time.deltaTime);
                star.transform.rotation = point.transform.rotation;

                star.GetComponent<CircleMove>().PositionSave();

            }

        }
    }

    








}