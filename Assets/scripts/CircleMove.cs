using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleMove : MonoBehaviour
{

    public float rotateSpeed;
    public Rigidbody2D rigid;
    public GameObject panel;

    public GameObject target;
    

    public bool circleMove = false; //이동시 ON

    


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        
    }
   

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0) && circleMove == false)
        {
            circleMove = true;


        }

        if (circleMove == true)
        {
            //bc();
            //rigid.velocity = Vector2.zero;
            //rigid.AddRelativeForce(Vector2.up * rotateSpeed);

            //Vector3 v3 = rigid.velocity;
            Vector3 v3 = target.transform.position - this.transform.position;//방향
            v3 = v3.normalized;

            //rigid.AddForce(v3 * rotateSpeed, ForceMode2D.Force);
           
            rigid.AddForce(v3 * rotateSpeed);
            //rigid.AddForce(v3.normalized * rotateSpeed);
            rigid.velocity = Vector2.zero;
        }

    }

 

    

    public void PositionSave()
    {
        PlayerPrefs.SetFloat("starX", gameObject.transform.position.x);
        PlayerPrefs.SetFloat("starY", gameObject.transform.position.y);
        PlayerPrefs.Save();
    }

    public void PositionLoad()
    {
        
        gameObject.SetActive(true);
        float x = PlayerPrefs.GetFloat("starX");
        float y = PlayerPrefs.GetFloat("starY");
        
        
        gameObject.transform.position = new Vector3(x, y, 0);
        panel.SetActive(false);


    }

    

    

}


    
    




