using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroler : MonoBehaviour
{

	public float speed = 5f;
	public float jspeed = 4f;
	private float movement = 0f;
	private Rigidbody2D rigidbody;
	public Transform growndcheck;
	public float growndcheckrd;
	public LayerMask growndLayer;
	private bool istouch;
	private Animator playerAnimation;
	public Vector3 RPoint;
	public LevelManager gameLevelManager;

	// Use this for initialization
	void Start()
	{
		rigidbody = GetComponent<Rigidbody2D>();
		playerAnimation = GetComponent<Animator>();
		RPoint = transform.position;
		gameLevelManager = FindObjectOfType<LevelManager>();
	}

	// Update is called once per frame
	void Update()
	{
		istouch = Physics2D.OverlapCircle(growndcheck.position, growndcheckrd, growndLayer);
		movement = Input.GetAxis("Horizontal");
		//Debug.Log(movement);
		if (movement > 0f)
		{
			rigidbody.velocity = new Vector2(movement * speed, rigidbody.velocity.y);
			transform.localScale = new Vector2(0.651168f, 0.651168f);
		}
		else if (movement < 0f)
		{
			rigidbody.velocity = new Vector2(movement * speed, rigidbody.velocity.y);
			transform.localScale = new Vector2(-0.651168f, 0.651168f);
		}
		else
		{
			rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
		}
		if (Input.GetButtonDown("Jump")&& istouch == true){
			rigidbody.velocity = new Vector2(rigidbody.velocity.x, jspeed);
		}
		playerAnimation.SetFloat("Speed", Mathf.Abs(rigidbody.velocity.x));
		playerAnimation.SetBool("Ongrownd", istouch);
	}


	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Falldetect")
		{
			gameLevelManager.Respawn();
			//What will happend when player enter the fall dt point

		}
		if(other.tag == "Checkpoint")
		{
			RPoint = other.transform.position;
		}
	}



}
