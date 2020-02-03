using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cir : MonoBehaviour
{
    private LevelManager gameLevelManager;
    public int coinValue;

public int score = 0;

	// Use this for initialization
	void Start ()
    {
        gameLevelManager = FindObjectOfType<LevelManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
        if(other.tag == "Player")
        {
            gameLevelManager.Addconits(coinValue);
            Destroy(gameObject);
        }
		/*Debug.Log("Triggered");
		Destroy(gameObject);
		score += 10;
		Debug.Log("Score: " + score);*/
	}
}
//if (Debug.Log("Triggered"))
		//{
			//Destroy(gameObject);
//score += 10;
			//Debug.Log("Score: " + score);
		//}
