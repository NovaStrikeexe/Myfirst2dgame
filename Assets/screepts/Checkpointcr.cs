using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpointcr : MonoBehaviour

{
	public Sprite Blueflag;
	public Sprite Redflag;
	private SpriteRenderer checkpointSpriterenderer;
	public bool ckisreached;
	// Start is called before the first frame update
	void Start()
    {
		checkpointSpriterenderer = GetComponent<SpriteRenderer> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player1"){
			checkpointSpriterenderer.sprite = Redflag;
			ckisreached = true;

		}
		
	}
}
