using UnityEngine;
using System.Collections;

public class StarProjectile : MonoBehaviour
{
	public float speed;
	public float deathTime = 3f;

	void Start()
	{
		rigidbody2D.AddForce (transform.right * speed);
	
	
	}

         void FixedUpdate (){
		float life = 10f;
		deathTime = Time.time + life;
		if (Time.time > deathTime)
			Destroy(gameObject);



}
}
//Vector2 => (x, y)
//Vector3 => (x, y, z)
//...