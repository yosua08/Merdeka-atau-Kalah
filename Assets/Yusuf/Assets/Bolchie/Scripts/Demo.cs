﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Basic Player Script//
//controls: 
//A, D, Left, Right to move
//Left Alt to attack
//Space to jump
//Z is to see dead animation

public class Demo : MonoBehaviour {

	//variable for how fast player runs//
	private float speed = 2f;

	private bool facingRight = true;
	private Animator anim;
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;

	//variable for how high player jumps//
	[SerializeField]
	private float jumpForce = 300f;

	public Rigidbody2D rb { get; set; }


	void Start () {
		GetComponent<Rigidbody2D> ().freezeRotation = true;
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponentInChildren<Animator> ();

	}

	void Update()
	{
		HandleInput ();
	}

	//movement//
	void FixedUpdate ()
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		float horizontal = Input.GetAxis("Horizontal");
		{
			anim.SetFloat ("vSpeed", rb.velocity.y);
			anim.SetFloat ("Speed", Mathf.Abs (horizontal));
			rb.velocity = new Vector2 (horizontal * speed, rb.velocity.y);
		}
		if (horizontal > 0 && !facingRight) {
			Flip (horizontal);
		}

		else if (horizontal < 0 && facingRight){
			Flip (horizontal);
		}
	}

	private void HandleInput()
	{

		if (grounded && Input.GetKeyDown(KeyCode.Space))
		{
			anim.SetBool ("Ground", false);
			rb.AddForce (new Vector2 (0,jumpForce));
		}
	}
		
	private void Flip (float horizontal)
	{
			facingRight = !facingRight;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
	}
}
