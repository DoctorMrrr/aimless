using UnityEngine;
using System.Collections;

public class StarProjectile : MonoBehaviour
{
	public float speed;


	void Start()
	{
		rigidbody2D.AddForce (transform.right * speed);
	
	  float deathTime = 3f;
	}

         void FixedUpdate (){
		float life = 10f;
		vdeathTime = Time.time + life;
		if (Time.time > deathTime)
			Destroy(gameObject);



}
}
//Vector2 => (x, y)
//Vector3 => (x, y, z)
//...