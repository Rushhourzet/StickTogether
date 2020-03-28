using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour {


    public float fac = 20;
    private Vector3 oldPos;
    // Use this for initialization
    void Start () {
        oldPos = transform.position;
        fac += Random.Range(-3, 3);
    }


	// Update is called once per frame
	void Update () {
        bool moving = oldPos != transform.position; 


        if (moving)
        {

            Vector3 theRotation = transform.eulerAngles;
            theRotation.z = Mathf.Sin(Time.time * fac) * 15; 
            transform.eulerAngles = theRotation;
        }



        oldPos = transform.position;
    }
}
