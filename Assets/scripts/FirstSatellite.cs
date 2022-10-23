using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSatellite : MonoBehaviour
{

    public GameObject target;
    public float rotate;

    private void Awake()
    {
        
        if (target) {
            rotate = target.GetComponent<start>().rotateSpeed;
        }

    }

    void Update()
    {
        
        if (target) {
            transform.RotateAround(target.transform.position, Vector3.back, rotate * Time.deltaTime);
        }
        
    }
}
