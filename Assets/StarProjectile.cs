using UnityEngine;
using System.Collections;

public class StarProjectile : MonoBehaviour
{
	public float speed;

	void Start()
	{
		rigidbody2D.AddForce (transform.right * speed);
	}
}

//Vector2 => (x, y)
//Vector3 => (x, y, z)
//...