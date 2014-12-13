using UnityEngine;
using System.Collections;

public class StarTileManager : MonoBehaviour
{
	public StarTileController centralTile;
	public StarTileController[] tileList;

	public float size;

	// Use this for initialization
	void Start ()
	{
		tileList = new StarTileController[9];
		for (int i = 0; i < tileList.Length; i++)
		{
			tileList[i] = transform.GetChild(i).GetComponent<StarTileController>();
			if (tileList[i].isCentral)
			{
				centralTile = tileList[i];
			}
		}
	}

	public void Rearrange()
	{
		for (int i = 0; i < tileList.Length; i++)
		{
			if ((centralTile.transform.position - tileList[i].transform.position).magnitude > 1.5f * size)
			{
				Destroy(tileList[i].gameObject);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
