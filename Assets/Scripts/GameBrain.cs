using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBrain : MonoBehaviour {


    public Color[] possibleColors;
    public Sprite[] Sprites;
    public Sprite[] RareSprites;

    public int startCount = 40;

    public GameObject player;

    public GameObject dude;

	// Use this for initialization
	void Start () {
        for(int i = 0; i < startCount; i++)
            SpawnDude(new Vector2(Random.Range(-10, 10), Random.Range(-10, 10)));

    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public GameBrain SpawnDude(Vector2 position)
    {
        if (Random.Range(0, 100) > 80)
        {
            GameObject gott = Instantiate(dude, position, new Quaternion(0, 0, 0, 0));

            gott.GetComponent<RunAway>().player = player.transform;
            gott.GetComponent<SpriteRenderer>().sprite = RareSprites[Random.Range(0, RareSprites.Length)];
            gott.GetComponent<SpriteRenderer>().color = Color.white;


            return this;
        }

        Debug.Log(Random.Range(0, possibleColors.Length));

        GameObject got = Instantiate(dude, position, new Quaternion(0,0,0,0));

        got.GetComponent<RunAway>().player = player.transform;
        got.GetComponent<SpriteRenderer>().sprite = Sprites[Random.Range(0, Sprites.Length)];
    Debug.Log(possibleColors[Random.Range(0, possibleColors.Length)]);

        //   got.GetComponent<SpriteRenderer>().color = 

        return this;
    }
}
