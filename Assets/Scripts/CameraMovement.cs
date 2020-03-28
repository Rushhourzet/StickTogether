
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Transform target;

    void Update()
    {
        if (target)
        {

            Vector3 targ = new Vector3(target.position.x, target.position.y, -5);


            transform.position = Vector3.Lerp(transform.position, targ, 0.1f);  
        }
    }
}
