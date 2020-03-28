using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameRotator : MonoBehaviour {


    [SerializeField] private SpriteRenderer[] renderers;

    [SerializeField] private Text toSet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { 
        

	}

    int count = 0;
    public void changeColors()
    {

        foreach (SpriteRenderer r in renderers)
            r.color = Random.ColorHSV();

        toSet.text = "See what you did? "+count++;
    }
}
