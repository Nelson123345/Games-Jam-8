using UnityEngine;
using System.Collections;

public class BreakObject : MonoBehaviour
{
/*	public Rigidbody gameObjectRigidBody;
	private Vector3 lastVelocity;
	public GameObject gameObjectToBreak;
	public GameObject brokenVersion;
	public Material brokenTexture; //Leave blank if there isn't one
	public Vector3 rotationOffset;
	public Vector3 positionOffset;
	private bool fractured;

	public float fractureAmplification;

	public float maxForce;

	private void Update()
	{
		lastVelocity = gameObjectRigidBody.velocity;

		if(Input.GetKeyDown(KeyCode.Space))
		{
			//fractureObject();
		}
	}

	public void fractureObject()
	{
		if(!fractured)
		{
			fractured = true;
			Quaternion objRot = Quaternion.Euler(gameObjectToBreak.transform.eulerAngles + rotationOffset);
			GameObject fractureParent = GameObject.Instantiate(brokenVersion, gameObjectToBreak.transform.position + positionOffset, objRot) as GameObject;
			Transform[] fragments = fractureParent.GetComponentsInChildren<Transform>();
				
			if(brokenTexture != null)
			{
				setMaterialForTransformArray(fragments, brokenTexture);
			}
			else
			{
				setMaterialForTransformArray(fragments, gameObjectToBreak.GetComponent<Renderer>().material);
			}
			Destroy(gameObjectToBreak);
			Destroy(this);
		}
	}

	public void setMaterialForTransformArray(Transform[] array, Material mat)
	{
		for(int i = 1; i < array.Length; i++)
		{
			if(array[i].gameObject.GetComponent<fragmentMaterialException>() == false)
			{
				Renderer fragmentRenderer = array[i].gameObject.GetComponent<Renderer>();
				fragmentRenderer.material = mat;
/*				array[i].GetComponent<Rigidbody>().AddForce(lastVelocity * fractureAmplification, ForceMode.Impulse);
*//*			}
		}
	}

	private void checkForFracture(Vector3 velocity, float maxForce)
	{
		float totalforce = Mathf.Abs(velocity.x) + Mathf.Abs(velocity.y) + Mathf.Abs(velocity.z);

		//print(totalforce);

		if(totalforce > maxForce)
		{
			//fractureObject();
		}
	}

	private void OnCollisionEnter(Collision collidedGameObject)
	{
		Rigidbody collidedGameObjectRigidbody = collidedGameObject.gameObject.GetComponent<Rigidbody>();
		if(collidedGameObjectRigidbody)
		{
			Vector3 velocityProduct;
			//print("Last Velocity: " + lastVelocity);

			velocityProduct = (collidedGameObjectRigidbody.velocity += gameObjectRigidBody.velocity);
			//print(velocityProduct);

			checkForFracture(velocityProduct, maxForce);
		}
		else
		{
			//print("Last Velocity: " + lastVelocity);
			checkForFracture(lastVelocity, maxForce);
		}
	}*/
}