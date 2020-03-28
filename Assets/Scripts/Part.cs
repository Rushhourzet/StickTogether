using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part : MonoBehaviour
{
    public bool isHead = false;

    public float speed = 5.5f;

    private Part toFollow;

    private Part last;

    void Start()
    {
        last = this;
    }

    public void SetPart(Part part)
    {
        toFollow = part;
    }


    void Update()
    {


        if (!isHead && toFollow != null)
        {
            float distance = Vector3.Distance(transform.position, toFollow.transform.position);

            //   transform.position = Vector3.Lerp(transform.position, toFollow.transform.position, 0.1f);


            if (distance > 1f)
            {
                speed = distance;

                transform.position = Vector3.MoveTowards(transform.position, toFollow.transform.position, (4 + speed) * Time.deltaTime);
            }

        }
        else
        {
            if (!isHead)
            {

            }
        }




    }

    public Timer timer;
    public Text point;
    public int count = 0;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isHead)
        {
            count++;
            point.text = "" + count;
            timer.timeRemaining += 2;
            Part p = collision.GetComponentsInParent<Part>()[0];

            p.SetPart(last);

            p.GetComponentInParent<BoxCollider2D>().enabled = false;
            p.GetComponentInParent<RunAway>().enabled = false;

            last = p;

        }
    }
}
