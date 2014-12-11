using UnityEngine;
using System.Collections;

public class StarProjectile : MonoBehaviour
{
	public float speed;
	public float deathTime = 15f;
	public float life;

	void Start()
	{
		rigidbody2D.AddForce (transform.right * speed);
	
		deathTime = Time.time + life;;
	}

         void FixedUpdate (){
		float life = 10f;
		if (Time.time > deathTime)
			Destroy(gameObject);



}
}
//Vector2 => (x, y)
//Vector3 => (x, y, z)
//...