using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour
{
	public string target;
	public CreateGoal createGoal;
	public LayerMask rayHitLayer;
	public PickedUpItems pickedUpItems;

	public Text targetText;

	private void Start()
	{
		target = createGoal.assignTarget();
		Cursor.lockState = CursorLockMode.Locked;
		//Cursor.visible(false);
		//Cursor.visible = true;
	}

	private void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			castRay(5f);
		}

		targetText.text = "Hey m8, forgot my " + target + " Can you go grab it for me";

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
		if(collidedObject.gameObject.name == target)
		{
			Destroy(collidedObject.gameObject);
			target = createGoal.assignTarget();
			pickedUpItems.pickedUpItems++;
		}
	}
}