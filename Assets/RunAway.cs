using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAway : MonoBehaviour
{

    public Transform player;

    public Vector3 targetDistance;

    void Start()
    {

        getPoint();
    }

    void getPoint()
    {
        float x = Random.Range(-4, 4);
        float y = Random.Range(-4, 4);

        targetDistance = new Vector3(transform.position.x + x, transform.position.y + y, 0);
    }


    void Update()
    {
        if(player!=null)
        if (Vector3.Distance(player.position, transform.position) < 7)
        {
            if (targetDistance == transform.position)
            {
                getPoint();
            }
            transform.position = Vector3.MoveTowards(transform.position, targetDistance, .05f);
        }



    }
}
