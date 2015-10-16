using UnityEngine;
using System.Collections;

public class PickUpItem : MonoBehaviour
{
	public string target;
	public LayerMask rayHitLayer;

	public static event OnPickUpDelegate onPickUp;
	private delegate void OnPickUpDelegate();
	
	private void castRay(float length)
	{
		RaycastHit rayHit;
		if (Physics.Raycast((transform.position), transform.forward, out rayHit, length, rayHitLayer))
		{
			onRaycastHit(rayHit.collider);
		}
	}

	public void onRaycastHit(Collider collidedObject)
	{
		if(collidedObject.gameObject.name == target && collidedObject.gameObject.tag == "CollectibleItem")
		{

		}
	}
}