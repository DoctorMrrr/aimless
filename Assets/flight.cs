using UnityEngine;
using System.Collections;

public class flight : MonoBehaviour
{
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
		direction.vector = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical")).normalized;
		if ( direction.vector.sqrMagnitude > 0.1f )
		{
			rigidbody2D.AddForce (direction.vector * flightSpeed);
			animator.SetBool ("engine", true);
			float angle = rigidbody2D.rotation;
			float difference =
				Mathf.Rad2Deg * Mathf.Atan2 (
					Mathf.Sin (Mathf.Deg2Rad * direction.angle - Mathf.Deg2Rad * angle),
					Mathf.Cos (Mathf.Deg2Rad * direction.angle - Mathf.Deg2Rad * angle)
					);
			rigidbody2D.angularVelocity = difference * rotation_factor;
		}
		else
		{
			animator.SetBool ("engine", false);
		}
		Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);
	}
}
	
