﻿using UnityEngine;
using System.Collections;

public class flight : MonoBehaviour {
	
	public float flightSpeed;
	public float rotation_factor = 1f;
	public Direction direction;
	public Animator animator;
	public bool startengine = false;
	// Use this for initialization
	void Start () {

		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		rigidbody2D.AddForce ((new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"))*flightSpeed ));
		
		direction.vector = rigidbody2D.velocity;
		if (direction.vector.magnitude > 0) 
		{
						float angle = rigidbody2D.rotation;

						float difference =
				Mathf.Rad2Deg * Mathf.Atan2 (
					Mathf.Sin (Mathf.Deg2Rad * direction.angle - Mathf.Deg2Rad * angle),
					Mathf.Cos (Mathf.Deg2Rad * direction.angle - Mathf.Deg2Rad * angle)
						);
						rigidbody2D.angularVelocity = difference * rotation_factor;
				}
		Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);

		if(animator)
		{

			if  (Input.GetButtonDown("Horizontal"))
		{

			animator.SetBool("startengine", true );

				
		}
		else {
			animator.SetBool("startengine", false );
		}
		}
	}
}
	
