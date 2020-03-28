using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public GameObject player;
    public Camera cam;

    public float timeRemaining = 60;
    public Text text;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            string mmin = ((int)(timeRemaining / 60))+"";
            string msec = (timeRemaining % 60).ToString("f2");

            if (msec.Length < 5) msec = "0" + msec;

            text.text = mmin+":" +msec.Replace(".",":");
        }
        else
        {
            player.GetComponent<Movement>().enabled = false;
            cam.orthographicSize += 0.05f;

            if (cam.orthographicSize > 15)
                cam.orthographicSize = 15;

            text.text = "Time's Over";
        }
    }
}
