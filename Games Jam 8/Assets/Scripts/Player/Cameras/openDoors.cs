using UnityEngine;
using System.Collections;

public class openDoors : MonoBehaviour {

	public LayerMask rayHitLayer;
	
	private void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			castRay(4f);
		}
	}
	
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
		if(collidedObject.gameObject.tag == "Door")
		{
			Animator doorAni = collidedObject.GetComponent<Animator>();
			if(doorAni)
			{
				if(doorAni.GetBool("isOpen"))
				{
					doorAni.SetBool("isOpen", false);
				}
				else
				{
					doorAni.SetBool("isOpen", true);
				}
				doorAni = null;
			}
		}		
	}
}
