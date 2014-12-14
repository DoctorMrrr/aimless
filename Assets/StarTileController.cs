using UnityEngine;
using System.Collections;

public class StarTileController : MonoBehaviour
{
	void OnTriggerExit2D (Collider2D collision)
	{
		if (collision.tag == "Player")
		{
            float stepsX = 0;
            float stepsY = 0;

            if (collision.transform.position.x > collider2D.bounds.max.x)
            {
                stepsX = Mathf.Ceil(
                    (
                        Mathf.Abs(collision.transform.position.x - collider2D.bounds.center.x) - collider2D.bounds.extents.x
                    ) / (collider2D.bounds.extents.x * 2f)
                );
            }
            else if (collision.transform.position.x < collider2D.bounds.min.x)
            {
                stepsX = -Mathf.Ceil(
                    (
                        Mathf.Abs(collision.transform.position.x - collider2D.bounds.center.x) - collider2D.bounds.extents.x
                    ) / (collider2D.bounds.extents.x * 2f)
                );
            }

            if (collision.transform.position.y > collider2D.bounds.max.y)
            {
                stepsY = Mathf.Ceil(
                    (
                        Mathf.Abs(collision.transform.position.y - collider2D.bounds.center.y) - collider2D.bounds.extents.y
                    ) / (collider2D.bounds.extents.y * 2f)
                );
            }
            else if (collision.transform.position.y < collider2D.bounds.min.y)
            {
                stepsY = -Mathf.Ceil(
                    (
                        Mathf.Abs(collision.transform.position.y - collider2D.bounds.center.y) - collider2D.bounds.extents.y
                    ) / (collider2D.bounds.extents.y * 2f)
                );
            }

            Vector3 closestPoint = new Vector2(stepsX * collider2D.bounds.extents.x * 2f, stepsY * collider2D.bounds.extents.y * 2f);
            transform.position += closestPoint;
		}
	}
}
