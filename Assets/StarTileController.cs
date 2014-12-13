using UnityEngine;
using System.Collections;

public class StarTileController : MonoBehaviour
{
	public bool isCentral;
	public StarTileManager manager;

	// Use this for initialization
	void Start () {
		manager = transform.parent.GetComponent<StarTileManager> ();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D (Collider2D collider)
	{
		if (!manager.centralTile.isCentral && collider.tag == "Player")
		{
			isCentral = true;
			manager.centralTile = this;
			manager.Rearrange();
		}
	}

	void OnTriggerExit2D (Collider2D collider)
	{
		if (collider.tag == "Player" && isCentral)
		{
			isCentral = false;
			//manager.transform.position = (collider.transform.position - manager.transform.position).normalized * 100f;
		}
	}
}
