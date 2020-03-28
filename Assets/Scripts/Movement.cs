using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movSpeed;


    private void Start()
    { 
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(horizontal * movSpeed/10f, vertical * movSpeed / 10f, 0),4);

        

    }
}
