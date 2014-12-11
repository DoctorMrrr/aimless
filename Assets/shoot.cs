using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	public StarProjectile star;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			StarProjectile newStar = Instantiate(star) as StarProjectile;
			newStar.transform.rotation = transform.rotation;
			newStar.transform.position = transform.position;
		}




	}
}
